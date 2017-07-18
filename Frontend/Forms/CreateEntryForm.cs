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
    public partial class CreateEntryForm : BaseActionForm
    {
        public object datas;
        

        public List<string> GroupNameCollection;
        private string groupName;
        private string groupId;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public string GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }

        public CreateEntryForm()
        {
            InitializeComponent();
        }

        public CreateEntryForm(IController controller) : base(controller)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IEntriesCrud entriesCrud = Controller.GetComponent<IEntriesCrud>();
            string groupId = GroupId;
            CallAsyncOperation(entriesCrud.CreateEntry, 
            new object[]
            {
                groupId,
                tbName.Text,
                tbUsername.Text,
                tbPassword.Text,
                tbNote.Text
            }
            );
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateEntryForm_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            tbGroupName.Text = GroupName;


        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
