using Backend.Core;
using System;
using System.Windows.Forms;
using Backend.GeneratedClasses;
using Frontend.Forms;


namespace Frontend
{
    public partial class BaseForm : Form
    {
        

        protected IController Controller;

        FormLoader _formLoader;

        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(IController controller)
        {
            InitializeComponent();
            Controller = controller;
        }
       
        protected void CallAsyncOperation(Func<object[], GeneralResponse> functionToExecute, object[] argument, bool refreshGui = false, Action<GeneralResponse> ReturnGeneralResponseFunction = null)
        {            
            _formLoader = new FormLoader();

            if (ReturnGeneralResponseFunction != null)
                FormLoader.RaiseEndOfLoading += ReturnGeneralResponseFunction;

            _formLoader.Init(functionToExecute, argument, refreshGui);
            _formLoader.ShowDialog(this);

            if (ReturnGeneralResponseFunction != null)
                FormLoader.RaiseEndOfLoading -= ReturnGeneralResponseFunction;
        }

        /*private void _formLoader_RaiseEndOfOperation(GeneralResponse gr, bool functionToExecuteCalled, bool refreshGui)
        {
            throw new NotImplementedException();
        }*/
    }
}
