namespace Frontend.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetAllData = new System.Windows.Forms.Button();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreateNewGroup = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnCreateNewEntry = new System.Windows.Forms.Button();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.entryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdInEntries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryLocation = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DeleteEntry = new System.Windows.Forms.Button();
            this.btnEditEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAllData
            // 
            this.btnGetAllData.Location = new System.Drawing.Point(575, 27);
            this.btnGetAllData.Name = "btnGetAllData";
            this.btnGetAllData.Size = new System.Drawing.Size(75, 48);
            this.btnGetAllData.TabIndex = 5;
            this.btnGetAllData.Text = "GetAllData";
            this.btnGetAllData.UseVisualStyleBackColor = true;
            this.btnGetAllData.Click += new System.EventHandler(this.btnGetAllData_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(11, 27);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(76, 48);
            this.btnCreateGroup.TabIndex = 13;
            this.btnCreateGroup.Text = "Create Group";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Enabled = false;
            this.btnEditGroup.Location = new System.Drawing.Point(153, 25);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(55, 42);
            this.btnEditGroup.TabIndex = 5;
            this.btnEditGroup.Text = "Edit Group";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.Location = new System.Drawing.Point(83, 25);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(55, 42);
            this.btnDeleteGroup.TabIndex = 4;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeColumns = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.GroupName});
            this.dgvGroups.Location = new System.Drawing.Point(12, 83);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.Size = new System.Drawing.Size(196, 230);
            this.dgvGroups.TabIndex = 2;
            this.dgvGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellClick);
            this.dgvGroups.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvGroups_KeyUp);
            // 
            // GroupId
            // 
            this.GroupId.HeaderText = "GroupId";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupName.HeaderText = "Group name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(827, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refersh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnCreateNewGroup
            // 
            this.btnCreateNewGroup.Location = new System.Drawing.Point(13, 25);
            this.btnCreateNewGroup.Name = "btnCreateNewGroup";
            this.btnCreateNewGroup.Size = new System.Drawing.Size(55, 42);
            this.btnCreateNewGroup.TabIndex = 0;
            this.btnCreateNewGroup.Text = "Create Group";
            this.btnCreateNewGroup.UseVisualStyleBackColor = true;
            this.btnCreateNewGroup.Click += new System.EventHandler(this.btnCreateNewGroup_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(903, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnCreateNewEntry
            // 
            this.btnCreateNewEntry.Enabled = false;
            this.btnCreateNewEntry.Location = new System.Drawing.Point(229, 25);
            this.btnCreateNewEntry.Name = "btnCreateNewEntry";
            this.btnCreateNewEntry.Size = new System.Drawing.Size(64, 42);
            this.btnCreateNewEntry.TabIndex = 6;
            this.btnCreateNewEntry.Text = "Create Entry";
            this.btnCreateNewEntry.UseVisualStyleBackColor = true;
            this.btnCreateNewEntry.Click += new System.EventHandler(this.btnCreateNewEntry_Click);
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            this.dgvEntries.AllowUserToResizeColumns = false;
            this.dgvEntries.AllowUserToResizeRows = false;
            this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryId,
            this.groupIdInEntries,
            this.EntryName,
            this.EntryLocation,
            this.Username,
            this.Password,
            this.Action,
            this.Note});
            this.dgvEntries.Location = new System.Drawing.Point(229, 83);
            this.dgvEntries.MultiSelect = false;
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.ReadOnly = true;
            this.dgvEntries.RowHeadersWidth = 30;
            this.dgvEntries.Size = new System.Drawing.Size(662, 230);
            this.dgvEntries.TabIndex = 7;
            this.dgvEntries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntries_CellClick);
            this.dgvEntries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntries_CellContentClick_1);
            // 
            // entryId
            // 
            this.entryId.HeaderText = "entryId";
            this.entryId.Name = "entryId";
            this.entryId.ReadOnly = true;
            this.entryId.Visible = false;
            // 
            // groupIdInEntries
            // 
            this.groupIdInEntries.HeaderText = "groupIdInEntries";
            this.groupIdInEntries.Name = "groupIdInEntries";
            this.groupIdInEntries.ReadOnly = true;
            this.groupIdInEntries.Visible = false;
            // 
            // EntryName
            // 
            this.EntryName.HeaderText = "Entry name";
            this.EntryName.Name = "EntryName";
            this.EntryName.ReadOnly = true;
            this.EntryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EntryName.Width = 115;
            // 
            // EntryLocation
            // 
            this.EntryLocation.HeaderText = "Location";
            this.EntryLocation.Name = "EntryLocation";
            this.EntryLocation.ReadOnly = true;
            this.EntryLocation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EntryLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Show password";
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_DeleteEntry
            // 
            this.btn_DeleteEntry.Enabled = false;
            this.btn_DeleteEntry.Location = new System.Drawing.Point(299, 25);
            this.btn_DeleteEntry.Name = "btn_DeleteEntry";
            this.btn_DeleteEntry.Size = new System.Drawing.Size(64, 42);
            this.btn_DeleteEntry.TabIndex = 8;
            this.btn_DeleteEntry.Text = "Delete Entry";
            this.btn_DeleteEntry.UseVisualStyleBackColor = true;
            this.btn_DeleteEntry.Click += new System.EventHandler(this.btn_DeleteEntry_Click_1);
            // 
            // btnEditEntry
            // 
            this.btnEditEntry.Enabled = false;
            this.btnEditEntry.Location = new System.Drawing.Point(369, 25);
            this.btnEditEntry.Name = "btnEditEntry";
            this.btnEditEntry.Size = new System.Drawing.Size(64, 42);
            this.btnEditEntry.TabIndex = 9;
            this.btnEditEntry.Text = "Edit\r\nEntry";
            this.btnEditEntry.UseVisualStyleBackColor = true;
            this.btnEditEntry.Click += new System.EventHandler(this.btnEditEntry_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(903, 330);
            this.Controls.Add(this.btnEditEntry);
            this.Controls.Add(this.btn_DeleteEntry);
            this.Controls.Add(this.dgvEntries);
            this.Controls.Add(this.btnCreateNewEntry);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreateNewGroup);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing_1);
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        
        private System.Windows.Forms.Button btnGetAllData;
        //private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnCreateGroup;
        #endregion

        private System.Windows.Forms.Button btnCreateNewGroup;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.Button btnCreateNewEntry;
        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.Button btn_DeleteEntry;
        private System.Windows.Forms.Button btnEditEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdInEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryName;
        private System.Windows.Forms.DataGridViewLinkColumn EntryLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}