using Backend.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Components.Entry;
using Backend.GeneratedClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Frontend.Forms
{
    public partial class FormMain : BaseForm
    {
        private CreateGroupForm frmCreateGroupForm = null;
        private EditGroupForm frmEditGroupForm = null;
        private CreateEntryForm frmCreateEntry = null;
        private EditEntryForm frmEditEntry = null;
        private JArray arrayOfGroups = null;
        private JArray arrayOfEntries = null;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(IController controller) : base(controller)
        {
            InitializeComponent();
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
            FormLoader.RaiseEndOfGetAlldata += EndOfGetAllDataHandler;
            CallAsyncOperation(null, new object[] { });
        }



      

        private void btnGetAllData_Click(object sender, EventArgs e)
        {


        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {


        }

        private void btnCreateNewGroup_Click(object sender, EventArgs e)
        {
           
            if (frmCreateGroupForm == null)
            {
                frmCreateGroupForm = new CreateGroupForm(Controller);
            }

            frmCreateGroupForm.ShowDialog(this);
            
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {     
            CallAsyncOperation(null, new object[] { });
        }

        public void EndOfOperationHandler(GeneralResponse gr)
        {
            
        }

        public void EndOfGetAllDataHandler(GeneralResponse gr, bool refreshGui) // handle null gr object properly
        {
            try
            {
                if (!refreshGui)
                {
                    IEntriesCrud entriesCrudComponent = Controller.GetComponent<IEntriesCrud>();
                    CallAsyncOperation(entriesCrudComponent.ViewAllGroupsAndEntries, new object[] { }, true);

                    return;
                }

                if (InvokeRequired)
                {
                    Invoke(new FormLoader.EndOfGetAllDataDelegate(EndOfGetAllDataHandler), gr, refreshGui);

                    return;
                }
                //staro
                //var parsed = JObject.Parse(gr.Data.ToString());
                //var val = (JValue)parsed["data"];
                //var arrayOfGroups = JArray.Parse(val.ToString(CultureInfo.InvariantCulture));
                //if(gr.Data == null)
                //{
                //    throw new Exception();
                //}
               
                var jObject = JObject.Parse(gr.Data.ToString());
                IDictionary<string, JToken> json = jObject;
                if(json["data"] == null)
                {
                    return;
                }
                var Jdata = json["data"];

                var jObjectData = JObject.Parse(Jdata.ToString());
                IDictionary<string, JToken> jsonData = jObjectData;
                var jgroup= jsonData["group"];
                var jentry = jsonData["entry"];
              
                 arrayOfGroups = JArray.Parse(jgroup.ToString());
                 arrayOfEntries = JArray.Parse(jentry.ToString());
               
                try
                {
                    FillDataGridView(dgvGroups, arrayOfGroups, ArrayType.Group, true, 0);
                    FillDataGridView(dgvEntries, arrayOfEntries, ArrayType.Entry, true, 0);
                }
                catch (Exception ex)
                {
                    gr.Success = false;
                    gr.ErrorMessage = @"Array of elements is empty or not properly formated. Additional information: " +
                                      ex.Message;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            btnEditGroup.Enabled = false;
            btnDeleteGroup.Enabled = false;
            btnCreateNewEntry.Enabled = false;
            btn_DeleteEntry.Enabled = false;
            btnEditEntry.Enabled = false;
        }

        private void FillDataGridView(DataGridView dgvName, JArray jarray, ArrayType type, bool allGroups, int itemId)
        {
            if (allGroups)
            {
                dgvName.Rows.Clear();
                if (type == ArrayType.Group)
                {
                   foreach (JToken jToken in jarray)
                    {
                        int groupId = jToken.Value<int>("id");
                        string groupName = jToken.Value<string>("name");
                        dgvName.Rows.Add(groupId, groupName);
                    }
                }
                else if (type == ArrayType.Entry)
                {
                    foreach (JToken jToken in jarray)
                    {
                        int entryId = jToken.Value<int>("id");
                        int groupId = jToken.Value<int>("groupId");
                        string name = jToken.Value<string>("name");
                        string entryLocation = jToken.Value<string>("location");
                        string username = jToken.Value<string>("username");
                        string password = jToken.Value<string>("password");
                        const string action = "View password";
                        string note = jToken.Value<string>("note");
                        dgvName.Rows.Add(entryId, groupId, name, entryLocation, username, password, action, note);
                    }
                }
            }
            else
            {
                foreach (JToken jToken in jarray)
                {
                    if (itemId == jToken.Value<int>("groupId"))
                    {
                        int entryId = jToken.Value<int>("id");
                        int groupId = jToken.Value<int>("groupId");
                        string name = jToken.Value<string>("name");
                        string entryLocation = jToken.Value<string>("location");
                        string username = jToken.Value<string>("username");
                        string password = jToken.Value<string>("password");
                        const string action = "View password";
                        string note = jToken.Value<string>("note");
                        dgvName.Rows.Add(entryId, groupId, name, entryLocation, username, password, action, note);
                    }
                }
            }

            dgvName.ClearSelection();  
        }

        public enum  ArrayType
        {
            Group,
            Entry
        }

        private void dgvGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteGroup.Enabled = true;
            btnEditGroup.Enabled = true;
            btnCreateNewEntry.Enabled = true;

            btnEditEntry.Enabled = false;
            btn_DeleteEntry.Enabled = false;

            FillEntriesForSelectedGroup();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvGroups.CurrentCell.RowIndex;

            string itemName = dgvGroups.Rows[rowIndex].Cells[1].Value.ToString();
            string itemid = dgvGroups.Rows[rowIndex].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure to delete \"" + itemName + "\"" + " group?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                #region Delete group component

                IGroupsCrud groupCrudComponent = Controller.GetComponent<IGroupsCrud>();

                try
                {
                    CallAsyncOperation(groupCrudComponent.DeleteGroup, new object[] { itemid } );
                    dgvGroups.Update();
                    dgvGroups.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                #endregion
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (frmEditGroupForm == null)
            {
                frmEditGroupForm = new EditGroupForm(Controller);
            }
            
            string groupName = GetSelectedCellValue(dgvGroups, "GroupName");
            string groupId = GetSelectedCellValue(dgvGroups, "groupId");

            frmEditGroupForm.GroupId = groupId;
            frmEditGroupForm.GroupName = groupName;

            frmEditGroupForm.ShowDialog(this);
            
        }

        private void btnCreateNewEntry_Click(object sender, EventArgs e)
        {
            if (frmCreateEntry == null)
            {
                frmCreateEntry = new CreateEntryForm(Controller);
            }
            try
            {
                string groupName = GetSelectedCellValue(dgvGroups, "GroupName");
                string groupId = GetSelectedCellValue(dgvGroups, "groupId");
                frmCreateEntry.GroupName = groupName;
                frmCreateEntry.GroupId = groupId;
                frmCreateEntry.ShowDialog(this);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private string GetSelectedCellValue(DataGridView dataGridView, string cellName)
        {
            try
            {
                int rowIndex = dataGridView.CurrentCell.RowIndex;
                string cellValue = dataGridView.Rows[rowIndex].Cells[cellName].Value.ToString();
                return cellValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        private void btn_DeleteEntry_Click_1(object sender, EventArgs e)
        {
            string entryName = GetSelectedCellValue(dgvEntries, "entryName");
            DialogResult dr = MessageBox.Show("Are you sure you want to delete \"" + entryName + "\" entry?",
                "Confirm",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    IEntriesCrud iEntriesCrud = Controller.GetComponent<IEntriesCrud>();

                    int entryId = int.Parse(GetSelectedCellValue(dgvEntries, "entryId"));
                    CallAsyncOperation(iEntriesCrud.DeleteEntry, new object[] {entryId});
                    dgvEntries.Update();
                    dgvEntries.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            
        }

        private void btnEditEntry_Click_1(object sender, EventArgs e)
        {
            if (frmEditEntry == null)
            {
                frmEditEntry = new EditEntryForm(Controller);
            }
            
            frmEditEntry.EntryId = GetSelectedCellValue(dgvEntries, "entryId");
            frmEditEntry.GroupName = GetSelectedCellValue(dgvGroups, "GroupName");
            frmEditEntry.EntryName = GetSelectedCellValue(dgvEntries, "entryName");
            frmEditEntry.EntryLocation = GetSelectedCellValue(dgvEntries, "EntryLocation");
            frmEditEntry.Username = GetSelectedCellValue(dgvEntries, "username");
            frmEditEntry.Password = GetSelectedCellValue(dgvEntries, "password");
            frmEditEntry.Note = GetSelectedCellValue(dgvEntries, "note");

            frmEditEntry.ShowDialog(this);

        }

        private void dgvEntries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditEntry.Enabled = true;
            btn_DeleteEntry.Enabled = true;
        }
        

        private void dgvGroups_KeyUp(object sender, KeyEventArgs e)
        {
            FillEntriesForSelectedGroup();
        }

        private void FillEntriesForSelectedGroup()
        {
            int rowIndex = dgvGroups.CurrentCell.RowIndex;
            int itemid = (int)dgvGroups.Rows[rowIndex].Cells[0].Value;
            dgvEntries.ClearSelection();
            dgvEntries.Rows.Clear();
            FillDataGridView(dgvEntries, arrayOfEntries, ArrayType.Entry, false, itemid);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }
        #region FormClosing red X => app.exit()
        private const int SC_CLOSE = 61536;
        private const int WM_SYSCOMMAND = 274;
        private bool close = false;

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
            {
                this.close = true;
            }

            base.WndProc(ref msg);
        }
    
        private void FormMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (this.close)
            {
                Application.Exit();
            }
        }
        #endregion

        private void dgvEntries_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            #region Location's HyperLink


            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)

                {
                    string link = dgvEntries.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    System.Diagnostics.Process.Start(link);
                } 
            }
            catch
            {
                MessageBox.Show("Invalid address of the location");
            }
            #endregion
            
            #region Show Password Button
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string entryId = GetSelectedCellValue(dgvEntries, "entryId");
                IEntriesCrud entriesCrud = Controller.GetComponent<IEntriesCrud>();
                
                string input = "";
                DialogResult dr = ShowInputDialog(ref input);

                if(dr == DialogResult.OK)
                {
                    string masterPassword = input;
                    CallAsyncOperation(entriesCrud.DecryptPassword, new object[] { entryId, masterPassword }, true, CallBackDecryptPasswordFunction);
                    
                }
            }
            #endregion

        }
        private void CallBackDecryptPasswordFunction(GeneralResponse gr)
        {
            if (gr.Data != null)
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
        private DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(250, 70);
            Form inputBox = new Form();


            //inputBox.Parent = this.Parent;
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Enter master password";
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;
            inputBox.FormBorderStyle = FormBorderStyle.FixedSingle;
            

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            textBox.PasswordChar = '*';
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);
            

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
  
            input = textBox.Text;
            return result;
        }

        private void sessionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
