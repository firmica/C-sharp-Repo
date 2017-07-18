using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Core;
using Backend.Components.Entry;
using Backend.GeneratedClasses;

namespace Frontend.Forms
{
    public partial class ViewPasswordForm : BaseForm
    {
        public ViewPasswordForm()
        {
            InitializeComponent();
        }
        public ViewPasswordForm(IController controller) : base(controller)
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            IEntriesCrud entriesCrud = Controller.GetComponent<IEntriesCrud>();
            CallAsyncOperation(entriesCrud.DecryptPassword, new object[] { 98, "pass" }, false, CallBackDecryptPasswordFunction);
        }
        private void CallBackDecryptPasswordFunction(GeneralResponse gr)
        {
            string password = gr.Data["original"].ToString();
            try
            {
                if (MessageBox.Show("your password is: " + password + Environment.NewLine + "Would you like to copy your password to clipboard?", "Password", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                { Clipboard.SetText(password); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
