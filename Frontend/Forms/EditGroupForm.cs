using Backend.Components.Entry;
using System;
using System.Security.Cryptography.X509Certificates;
using Backend.Core;


namespace Frontend.Forms
{
    public partial class EditGroupForm : BaseActionForm
    {
        public EditGroupForm()
        {
            InitializeComponent();
        }

        private string groupId;
        private string groupName;

        public string GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public EditGroupForm(IController controller) : base(controller)
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string groupId = GroupId;
            IGroupsCrud groupCrudComponent = Controller.GetComponent<IGroupsCrud>();

            CallAsyncOperation(groupCrudComponent.EditGroup, new object [] { groupId, tbGroupName.Text });
            this.Close();

        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            tbGroupName.Clear();
            tbGroupName.Text = GroupName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
