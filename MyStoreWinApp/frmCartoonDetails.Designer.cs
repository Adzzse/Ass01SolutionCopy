
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
            txtLaunchDate = new System.Windows.Forms.TextBox();
            lbLaunchDate = new System.Windows.Forms.Label();
            txtDirector = new System.Windows.Forms.TextBox();
            lbDirector = new System.Windows.Forms.Label();
            txtShortDescription = new System.Windows.Forms.TextBox();
            lbShortDescription = new System.Windows.Forms.Label();
            txtCartoonName = new System.Windows.Forms.TextBox();
            lbCartoonName = new System.Windows.Forms.Label();
            txtCartoonID = new System.Windows.Forms.TextBox();
            lbCartoonID = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbActors = new System.Windows.Forms.Label();
            txtActors = new System.Windows.Forms.TextBox();
            txtProducer = new System.Windows.Forms.TextBox();
            lbProducer = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            txtDuration = new System.Windows.Forms.TextBox();
            lbDuration = new System.Windows.Forms.Label();
            txtCartoonType = new System.Windows.Forms.TextBox();
            lbCartoonType = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtLaunchDate
            // 
            txtLaunchDate.Location = new System.Drawing.Point(532, 240);
            txtLaunchDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLaunchDate.Name = "txtLaunchDate";
            txtLaunchDate.Size = new System.Drawing.Size(210, 27);
            txtLaunchDate.TabIndex = 23;
            // 
            // lbLaunchDate
            // 
            lbLaunchDate.AutoSize = true;
            lbLaunchDate.Location = new System.Drawing.Point(413, 244);
            lbLaunchDate.Name = "lbLaunchDate";
            lbLaunchDate.Size = new System.Drawing.Size(91, 20);
            lbLaunchDate.TabIndex = 22;
            lbLaunchDate.Text = "Launch Date";
            // 
            // txtDirector
            // 
            txtDirector.Location = new System.Drawing.Point(142, 187);
            txtDirector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new System.Drawing.Size(210, 27);
            txtDirector.TabIndex = 18;
            // 
            // lbDirector
            // 
            lbDirector.AutoSize = true;
            lbDirector.Location = new System.Drawing.Point(23, 191);
            lbDirector.Name = "lbDirector";
            lbDirector.Size = new System.Drawing.Size(63, 20);
            lbDirector.TabIndex = 18;
            lbDirector.Text = "Director";
            lbDirector.Click += lbPassword_Click;
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(142, 129);
            txtShortDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new System.Drawing.Size(210, 27);
            txtShortDescription.TabIndex = 17;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(23, 133);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(85, 20);
            lbShortDescription.TabIndex = 16;
            lbShortDescription.Text = "Description";
            // 
            // txtCartoonName
            // 
            txtCartoonName.Location = new System.Drawing.Point(142, 75);
            txtCartoonName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCartoonName.Name = "txtCartoonName";
            txtCartoonName.Size = new System.Drawing.Size(210, 27);
            txtCartoonName.TabIndex = 15;
            // 
            // lbCartoonName
            // 
            lbCartoonName.AutoSize = true;
            lbCartoonName.Location = new System.Drawing.Point(23, 79);
            lbCartoonName.Name = "lbCartoonName";
            lbCartoonName.Size = new System.Drawing.Size(106, 20);
            lbCartoonName.TabIndex = 14;
            lbCartoonName.Text = "Cartoon Name";
            // 
            // txtCartoonID
            // 
            txtCartoonID.Location = new System.Drawing.Point(142, 20);
            txtCartoonID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCartoonID.Name = "txtCartoonID";
            txtCartoonID.Size = new System.Drawing.Size(210, 27);
            txtCartoonID.TabIndex = 13;
            // 
            // lbCartoonID
            // 
            lbCartoonID.AutoSize = true;
            lbCartoonID.Location = new System.Drawing.Point(23, 24);
            lbCartoonID.Name = "lbCartoonID";
            lbCartoonID.Size = new System.Drawing.Size(81, 20);
            lbCartoonID.TabIndex = 12;
            lbCartoonID.Text = "Cartoon ID";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAdd.Location = new System.Drawing.Point(237, 293);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(107, 31);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnUpdate.Location = new System.Drawing.Point(237, 293);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(107, 31);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(422, 293);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(107, 31);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new System.Drawing.Point(23, 243);
            lbActors.Name = "lbActors";
            lbActors.Size = new System.Drawing.Size(51, 20);
            lbActors.TabIndex = 18;
            lbActors.Text = "Actors";
            // 
            // txtActors
            // 
            txtActors.Location = new System.Drawing.Point(142, 239);
            txtActors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtActors.Name = "txtActors";
            txtActors.Size = new System.Drawing.Size(210, 27);
            txtActors.TabIndex = 19;
            txtActors.TextChanged += txtActors_TextChanged;
            // 
            // txtProducer
            // 
            txtProducer.Location = new System.Drawing.Point(532, 130);
            txtProducer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new System.Drawing.Size(210, 27);
            txtProducer.TabIndex = 30;
            // 
            // lbProducer
            // 
            lbProducer.AutoSize = true;
            lbProducer.Location = new System.Drawing.Point(413, 133);
            lbProducer.Name = "lbProducer";
            lbProducer.Size = new System.Drawing.Size(68, 20);
            lbProducer.TabIndex = 29;
            lbProducer.Text = "Producer";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(532, 20);
            txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(210, 27);
            txtCountry.TabIndex = 28;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(413, 24);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 27;
            lbCountry.Text = "Country";
            lbCountry.Click += label2_Click;
            // 
            // txtDuration
            // 
            txtDuration.Location = new System.Drawing.Point(532, 184);
            txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new System.Drawing.Size(210, 27);
            txtDuration.TabIndex = 34;
            // 
            // lbDuration
            // 
            lbDuration.AutoSize = true;
            lbDuration.Location = new System.Drawing.Point(413, 188);
            lbDuration.Name = "lbDuration";
            lbDuration.Size = new System.Drawing.Size(67, 20);
            lbDuration.TabIndex = 33;
            lbDuration.Text = "Duration";
            // 
            // txtCartoonType
            // 
            txtCartoonType.Location = new System.Drawing.Point(532, 76);
            txtCartoonType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCartoonType.Name = "txtCartoonType";
            txtCartoonType.Size = new System.Drawing.Size(210, 27);
            txtCartoonType.TabIndex = 32;
            // 
            // lbCartoonType
            // 
            lbCartoonType.AutoSize = true;
            lbCartoonType.Location = new System.Drawing.Point(413, 79);
            lbCartoonType.Name = "lbCartoonType";
            lbCartoonType.Size = new System.Drawing.Size(97, 20);
            lbCartoonType.TabIndex = 31;
            lbCartoonType.Text = "Cartoon Type";
            // 
            // frmCartoonDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(799, 351);
            Controls.Add(txtDuration);
            Controls.Add(lbDuration);
            Controls.Add(txtCartoonType);
            Controls.Add(lbCartoonType);
            Controls.Add(txtProducer);
            Controls.Add(lbProducer);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLaunchDate);
            Controls.Add(lbLaunchDate);
            Controls.Add(txtActors);
            Controls.Add(lbActors);
            Controls.Add(txtDirector);
            Controls.Add(lbDirector);
            Controls.Add(txtShortDescription);
            Controls.Add(lbShortDescription);
            Controls.Add(txtCartoonName);
            Controls.Add(lbCartoonName);
            Controls.Add(txtCartoonID);
            Controls.Add(lbCartoonID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCartoonDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCartoonDetails";
            Load += frmCartoonDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLaunchDate;
        private System.Windows.Forms.Label lbLaunchDate;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.TextBox txtCartoonName;
        private System.Windows.Forms.Label lbCartoonName;
        private System.Windows.Forms.TextBox txtCartoonID;
        private System.Windows.Forms.Label lbCartoonID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbActors;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lbProducer;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.TextBox txtCartoonType;
        private System.Windows.Forms.Label lbCartoonType;
    }
}