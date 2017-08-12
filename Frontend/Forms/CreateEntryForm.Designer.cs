namespace Frontend.Forms
{
    partial class CreateEntryForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lblEntryName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblEntryUsername = new System.Windows.Forms.Label();
            this.lblEntryPassword = new System.Windows.Forms.Label();
            this.lblEntryNote = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(290, 202);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbGroupName
            // 
            this.tbGroupName.Enabled = false;
            this.tbGroupName.Location = new System.Drawing.Point(77, 12);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(190, 20);
            this.tbGroupName.TabIndex = 0;
            // 
            // lblEntryName
            // 
            this.lblEntryName.AutoSize = true;
            this.lblEntryName.Location = new System.Drawing.Point(13, 42);
            this.lblEntryName.Name = "lblEntryName";
            this.lblEntryName.Size = new System.Drawing.Size(63, 13);
            this.lblEntryName.TabIndex = 9;
            this.lblEntryName.Text = "Entry name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(77, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(190, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(77, 89);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(190, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(77, 115);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(190, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Location = new System.Drawing.Point(8, 15);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(68, 13);
            this.lblGroupId.TabIndex = 8;
            this.lblGroupId.Text = "Group name:";
            // 
            // lblEntryUsername
            // 
            this.lblEntryUsername.AutoSize = true;
            this.lblEntryUsername.Location = new System.Drawing.Point(20, 92);
            this.lblEntryUsername.Name = "lblEntryUsername";
            this.lblEntryUsername.Size = new System.Drawing.Size(58, 13);
            this.lblEntryUsername.TabIndex = 11;
            this.lblEntryUsername.Text = "Username:";
            // 
            // lblEntryPassword
            // 
            this.lblEntryPassword.AutoSize = true;
            this.lblEntryPassword.Location = new System.Drawing.Point(20, 118);
            this.lblEntryPassword.Name = "lblEntryPassword";
            this.lblEntryPassword.Size = new System.Drawing.Size(56, 13);
            this.lblEntryPassword.TabIndex = 12;
            this.lblEntryPassword.Text = "Password:";
            // 
            // lblEntryNote
            // 
            this.lblEntryNote.AutoSize = true;
            this.lblEntryNote.Location = new System.Drawing.Point(43, 141);
            this.lblEntryNote.Name = "lblEntryNote";
            this.lblEntryNote.Size = new System.Drawing.Size(33, 13);
            this.lblEntryNote.TabIndex = 13;
            this.lblEntryNote.Text = "Note:";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(78, 141);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(189, 97);
            this.tbNote.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(25, 66);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(77, 63);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(190, 20);
            this.tbLocation.TabIndex = 2;
            // 
            // CreateEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 272);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lblEntryNote);
            this.Controls.Add(this.lblEntryPassword);
            this.Controls.Add(this.lblEntryUsername);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.lblEntryName);
            this.Name = "CreateEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateEntryForm";
            this.Load += new System.EventHandler(this.CreateEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label lblEntryName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblEntryUsername;
        private System.Windows.Forms.Label lblEntryPassword;
        private System.Windows.Forms.Label lblEntryNote;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbLocation;
    }
}