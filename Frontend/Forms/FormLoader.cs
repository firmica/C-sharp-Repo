using System;
using System.Threading;
using System.Windows.Forms;
using Backend.GeneratedClasses;

namespace Frontend.Forms
{    
    public partial class FormLoader : Form
    {
        public delegate void EndOfOperationDelegate(GeneralResponse gr, bool functionToExecuteCalled, bool refreshGui);
        public delegate void EndOfGetAllDataDelegate(GeneralResponse gr, bool refreshGui);

        public event EndOfOperationDelegate RaiseEndOfOperation;
        public static event EndOfGetAllDataDelegate RaiseEndOfGetAlldata;
        public static event Action<GeneralResponse> RaiseEndOfLoading;
  
        public FormLoader()
        {
            InitializeComponent();

            RaiseEndOfOperation += CloseThisForm; // a ovde se subscribe-uje       
        }

        public void Init(Func<object[], GeneralResponse> functionToExecute, object[] argument, bool refreshGui)
        {            
            Thread operationExecutionThread = new Thread(
                () =>
                {
                    GeneralResponse gr = null;

                    bool functionToExecuteIsCalled = functionToExecute != null;

                    if (functionToExecuteIsCalled)
                        gr = functionToExecute(argument);
                    
                    RaiseEndOfOperation?.Invoke(gr,  functionToExecuteIsCalled, refreshGui);
                    RaiseEndOfOperation -= CloseThisForm; //ovo resava problem, odmah se unsubscribe-uje                    
                }
            );
           
            operationExecutionThread.Start();            
        }      

        public void CloseThisForm(GeneralResponse gr, bool functionToExecuteCalled, bool refreshGui)
        {
            if (InvokeRequired)
            {

                Invoke(new EndOfOperationDelegate(CloseThisForm), gr, functionToExecuteCalled, refreshGui);

            }
            else
            {
                string message = "Success!";

                if (functionToExecuteCalled && !gr.Success)
                    message = $"Failure! Message: {gr.ErrorMessage}";

                if ((!refreshGui || !gr.Success) && functionToExecuteCalled)
                    MessageBox.Show(
                        message,
                        // ReSharper disable once LocalizableElement
                        "Web service response",
                        MessageBoxButtons.OK,
                        (!gr.Success) ? MessageBoxIcon.Error : MessageBoxIcon.Information
                    );

                Visible = false;
                if (Handle != IntPtr.Zero) //"This line of code grabs an unmanaged Windows handle. As a result, that handle must be manually cleaned up", ako nema ovoga, puca aplikacija kada se radi 'multiple rapid clicks' na refresh dugmetu
                    Close(); // is this a reason why formLoader is disposed?
               
                if (!functionToExecuteCalled || gr.Success)
                    RaiseEndOfGetAlldata?.Invoke(gr, refreshGui);
                

                if (functionToExecuteCalled)
                {
                    RaiseEndOfLoading?.Invoke(gr);
                }
            }
        }

        private void FromLoader_Load(object sender, EventArgs e)
        {            
        }
    }
}
