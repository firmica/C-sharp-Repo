using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Components;
using Backend.Core;
using Frontend.Forms;
using Backend.GeneratedClasses;

namespace Frontend
{
    public partial class Login : BaseForm
    {
        private FormMain _frmMain = null;

        public Login()
        {
            InitializeComponent();
        }

        public Login(IController controller) : base(controller)
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if(tbUsername.Text == "" || tbPassword.Text == "")
            //{
            //    MessageBox.Show("Please provide username and password.");
            //}
            //else
            //{
                ILoginComponent loginComponent = Controller.GetComponent<ILoginComponent>();
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                try
                {
                    CallAsyncOperation(loginComponent.Login, new object[] { username, password }, true, CallBackLoginFunction);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //}
          
        }
        private void OpenMainForm()
        {
            if (_frmMain == null)
            {
                _frmMain = new FormMain(Controller);
                _frmMain.FormClosed -= FrmMainFormClosed;
                _frmMain.FormClosed += FrmMainFormClosed;
            }
            _frmMain.Visible = false;
            _frmMain.Show(this);
            this.Hide(); 
        }
        
        private void FrmMainFormClosed(object sender, FormClosedEventArgs e)
        {
            _frmMain = null;
            Show();
        }

        private void CallBackLoginFunction(GeneralResponse gr)
        {
           if(gr.Success)
                OpenMainForm();
        }

    }
}
