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
    public partial class EditEntryForm : BaseActionForm
    {
        public EditEntryForm()
        {
            InitializeComponent();
        }
        public EditEntryForm(IController controller) : base (controller)
        {
            InitializeComponent();
        }

        public string EntryId { get; set; }
        public string GroupName { get; set; }
        public string EntryName { get; set; }
        public string EntryLocation { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEntryForm_Load(object sender, EventArgs e)
        {
            //tbEntryId.Clear();
            //tbGroupName.Clear();
            tbEntryId.Text = EntryId.ToString();
            tbGroupName.Text = GroupName;
            tbEntryName.Text = EntryName;
            tbLocation.Text = EntryLocation;
            tbEntryUsername.Text = Username;
            tbEntryPassword.Text = Password;
            tbEntryNote.Text = Note;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            IEntriesCrud IEntriesCrud = Controller.GetComponent<IEntriesCrud>();
            CallAsyncOperation(IEntriesCrud.EditEntry, new object[] { EntryId, tbEntryName.Text, tbLocation.Text, tbEntryUsername.Text, tbEntryPassword.Text, tbEntryNote.Text});
            this.Close();
            
        }
    }
}
