
namespace CartoonManagementWinApp_DoHoangAnh
{
    partial class frmCartoonDetails
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
            txtCountry = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            txtProducer = new System.Windows.Forms.TextBox();
            lbCity = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            txtShortDescription = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            txtCartoonName = new System.Windows.Forms.TextBox();
            lbCartoonName = new System.Windows.Forms.Label();
            txtCartoonID = new System.Windows.Forms.TextBox();
            lbCartoonID = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbConfirm = new System.Windows.Forms.Label();
            txtConfirm = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(124, 261);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(184, 23);
            txtCountry.TabIndex = 23;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(20, 264);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(55, 15);
            lbCountry.TabIndex = 22;
            lbCountry.Text = "Producer";
            // 
            // txtProducer
            // 
            txtProducer.Location = new System.Drawing.Point(124, 220);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new System.Drawing.Size(184, 23);
            txtProducer.TabIndex = 21;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(20, 223);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(55, 15);
            lbCity.TabIndex = 20;
            lbCity.Text = "Producer";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(124, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(184, 23);
            txtPassword.TabIndex = 18;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(20, 143);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Password";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(124, 97);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new System.Drawing.Size(184, 23);
            txtShortDescription.TabIndex = 17;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(20, 100);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email";
            // 
            // txtCartoonName
            // 
            txtCartoonName.Location = new System.Drawing.Point(124, 56);
            txtCartoonName.Name = "txtCartoonName";
            txtCartoonName.Size = new System.Drawing.Size(184, 23);
            txtCartoonName.TabIndex = 15;
            // 
            // lbCartoonName
            // 
            lbCartoonName.AutoSize = true;
            lbCartoonName.Location = new System.Drawing.Point(20, 59);
            lbCartoonName.Name = "lbCartoonName";
            lbCartoonName.Size = new System.Drawing.Size(85, 15);
            lbCartoonName.TabIndex = 14;
            lbCartoonName.Text = "Cartoon Name";
            // 
            // txtCartoonID
            // 
            txtCartoonID.Location = new System.Drawing.Point(124, 15);
            txtCartoonID.Name = "txtCartoonID";
            txtCartoonID.Size = new System.Drawing.Size(184, 23);
            txtCartoonID.TabIndex = 13;
            // 
            // lbCartoonID
            // 
            lbCartoonID.AutoSize = true;
            lbCartoonID.Location = new System.Drawing.Point(20, 18);
            lbCartoonID.Name = "lbCartoonID";
            lbCartoonID.Size = new System.Drawing.Size(64, 15);
            lbCartoonID.TabIndex = 12;
            lbCartoonID.Text = "Cartoon ID";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAdd.Location = new System.Drawing.Point(32, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 23);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnUpdate.Location = new System.Drawing.Point(32, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 23);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(194, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 23);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new System.Drawing.Point(20, 182);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new System.Drawing.Size(51, 15);
            lbConfirm.TabIndex = 18;
            lbConfirm.Text = "Confirm";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new System.Drawing.Point(124, 179);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new System.Drawing.Size(184, 23);
            txtConfirm.TabIndex = 19;
            // 
            // frmCartoonDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(343, 355);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtProducer);
            Controls.Add(lbCity);
            Controls.Add(txtConfirm);
            Controls.Add(lbConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtShortDescription);
            Controls.Add(lbEmail);
            Controls.Add(txtCartoonName);
            Controls.Add(lbCartoonName);
            Controls.Add(txtCartoonID);
            Controls.Add(lbCartoonID);
            Name = "frmCartoonDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCartoonDetails";
            Load += frmCartoonDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtCartoonName;
        private System.Windows.Forms.Label lbCartoonName;
        private System.Windows.Forms.TextBox txtCartoonID;
        private System.Windows.Forms.Label lbCartoonID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}