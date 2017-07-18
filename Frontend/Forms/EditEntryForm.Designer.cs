namespace Frontend.Forms
{
    partial class EditEntryForm
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
            this.tbEntryId = new System.Windows.Forms.TextBox();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.tbEntryName = new System.Windows.Forms.TextBox();
            this.tbEntryUsername = new System.Windows.Forms.TextBox();
            this.tbEntryPassword = new System.Windows.Forms.TextBox();
            this.tbEntryNote = new System.Windows.Forms.TextBox();
            this.lblEntryId = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblEntryName = new System.Windows.Forms.Label();
            this.lblEntryUsername = new System.Windows.Forms.Label();
            this.lblEntryPassword = new System.Windows.Forms.Label();
            this.lblEntryNote = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEntryId
            // 
            this.tbEntryId.Enabled = false;
            this.tbEntryId.Location = new System.Drawing.Point(80, 22);
            this.tbEntryId.Name = "tbEntryId";
            this.tbEntryId.Size = new System.Drawing.Size(191, 20);
            this.tbEntryId.TabIndex = 0;
            // 
            // tbGroupName
            // 
            this.tbGroupName.Enabled = false;
            this.tbGroupName.Location = new System.Drawing.Point(80, 48);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(191, 20);
            this.tbGroupName.TabIndex = 1;
            // 
            // tbEntryName
            // 
            this.tbEntryName.Location = new System.Drawing.Point(80, 74);
            this.tbEntryName.Name = "tbEntryName";
            this.tbEntryName.Size = new System.Drawing.Size(191, 20);
            this.tbEntryName.TabIndex = 2;
            // 
            // tbEntryUsername
            // 
            this.tbEntryUsername.Location = new System.Drawing.Point(80, 100);
            this.tbEntryUsername.Name = "tbEntryUsername";
            this.tbEntryUsername.Size = new System.Drawing.Size(191, 20);
            this.tbEntryUsername.TabIndex = 3;
            // 
            // tbEntryPassword
            // 
            this.tbEntryPassword.Location = new System.Drawing.Point(80, 126);
            this.tbEntryPassword.Name = "tbEntryPassword";
            this.tbEntryPassword.Size = new System.Drawing.Size(191, 20);
            this.tbEntryPassword.TabIndex = 4;
            // 
            // tbEntryNote
            // 
            this.tbEntryNote.Location = new System.Drawing.Point(80, 152);
            this.tbEntryNote.Multiline = true;
            this.tbEntryNote.Name = "tbEntryNote";
            this.tbEntryNote.Size = new System.Drawing.Size(191, 88);
            this.tbEntryNote.TabIndex = 5;
            // 
            // lblEntryId
            // 
            this.lblEntryId.AutoSize = true;
            this.lblEntryId.Location = new System.Drawing.Point(29, 25);
            this.lblEntryId.Name = "lblEntryId";
            this.lblEntryId.Size = new System.Drawing.Size(45, 13);
            this.lblEntryId.TabIndex = 6;
            this.lblEntryId.Text = "Entry id:";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(11, 51);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(68, 13);
            this.lblGroupName.TabIndex = 7;
            this.lblGroupName.Text = "Group name:";
            // 
            // lblEntryName
            // 
            this.lblEntryName.AutoSize = true;
            this.lblEntryName.Location = new System.Drawing.Point(36, 77);
            this.lblEntryName.Name = "lblEntryName";
            this.lblEntryName.Size = new System.Drawing.Size(38, 13);
            this.lblEntryName.TabIndex = 8;
            this.lblEntryName.Text = "Name:";
            // 
            // lblEntryUsername
            // 
            this.lblEntryUsername.AutoSize = true;
            this.lblEntryUsername.Location = new System.Drawing.Point(21, 103);
            this.lblEntryUsername.Name = "lblEntryUsername";
            this.lblEntryUsername.Size = new System.Drawing.Size(58, 13);
            this.lblEntryUsername.TabIndex = 9;
            this.lblEntryUsername.Text = "Username:";
            // 
            // lblEntryPassword
            // 
            this.lblEntryPassword.AutoSize = true;
            this.lblEntryPassword.Location = new System.Drawing.Point(18, 129);
            this.lblEntryPassword.Name = "lblEntryPassword";
            this.lblEntryPassword.Size = new System.Drawing.Size(56, 13);
            this.lblEntryPassword.TabIndex = 10;
            this.lblEntryPassword.Text = "Password:";
            // 
            // lblEntryNote
            // 
            this.lblEntryNote.AutoSize = true;
            this.lblEntryNote.Location = new System.Drawing.Point(41, 155);
            this.lblEntryNote.Name = "lblEntryNote";
            this.lblEntryNote.Size = new System.Drawing.Size(33, 13);
            this.lblEntryNote.TabIndex = 11;
            this.lblEntryNote.Text = "Note:";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(302, 22);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 12;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 258);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblEntryNote);
            this.Controls.Add(this.lblEntryPassword);
            this.Controls.Add(this.lblEntryUsername);
            this.Controls.Add(this.lblEntryName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblEntryId);
            this.Controls.Add(this.tbEntryNote);
            this.Controls.Add(this.tbEntryPassword);
            this.Controls.Add(this.tbEntryUsername);
            this.Controls.Add(this.tbEntryName);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.tbEntryId);
            this.Name = "EditEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditEntryForm";
            this.Load += new System.EventHandler(this.EditEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEntryId;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.TextBox tbEntryName;
        private System.Windows.Forms.TextBox tbEntryUsername;
        private System.Windows.Forms.TextBox tbEntryPassword;
        private System.Windows.Forms.TextBox tbEntryNote;
        private System.Windows.Forms.Label lblEntryId;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblEntryName;
        private System.Windows.Forms.Label lblEntryUsername;
        private System.Windows.Forms.Label lblEntryPassword;
        private System.Windows.Forms.Label lblEntryNote;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}