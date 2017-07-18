using Backend.GeneratedClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Components.Entry;
using Backend.Core;

namespace Frontend.Forms
{
    public partial class CreateGroupForm : BaseActionForm
    {

        public CreateGroupForm()
        {
            InitializeComponent();
        }

        public CreateGroupForm(IController controller) : base(controller)
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IGroupsCrud groupCrudComponent = Controller.GetComponent<IGroupsCrud>();
            CallAsyncOperation(groupCrudComponent.CreateGroup, new object[] { tbGroupName.Text });
            
            this.Close();
        }
       
        
        private void CreateGroupForm_Load(object sender, EventArgs e)
        {
            //FromLoader.RaiseEndOfOperation -= EndOfOperationHandler;
            //FromLoader.RaiseEndOfOperation += EndOfOperationHandler;
            
            tbGroupName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
