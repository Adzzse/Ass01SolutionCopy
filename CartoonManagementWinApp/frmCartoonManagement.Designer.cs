
namespace CartoonManagementWinApp_DOHOANGANH
{
    partial class frmCartoonManagement
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
            lbCartoonID = new System.Windows.Forms.Label();
            txtCartoonID = new System.Windows.Forms.TextBox();
            lbCartoonName = new System.Windows.Forms.Label();
            txtCartoonName = new System.Windows.Forms.TextBox();
            lbShortDescription = new System.Windows.Forms.Label();
            txtShortDescription = new System.Windows.Forms.TextBox();
            lbActors = new System.Windows.Forms.Label();
            txtActors = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvCartoonList = new System.Windows.Forms.DataGridView();
            lbSearch = new System.Windows.Forms.Label();
            txtSearchValue = new System.Windows.Forms.TextBox();
            lbSearchCountry = new System.Windows.Forms.Label();
            cboCountry = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            grSearch = new System.Windows.Forms.GroupBox();
            radioByActor = new System.Windows.Forms.RadioButton();
            radioByProducer = new System.Windows.Forms.RadioButton();
            grFilter = new System.Windows.Forms.GroupBox();
            txtDuration = new System.Windows.Forms.TextBox();
            lbDurartion = new System.Windows.Forms.Label();
            txtProducer = new System.Windows.Forms.TextBox();
            lbProducer = new System.Windows.Forms.Label();
            txtCartoonType = new System.Windows.Forms.TextBox();
            lbCartoonType = new System.Windows.Forms.Label();
            txtLaunchDate = new System.Windows.Forms.TextBox();
            lbLaunchDate = new System.Windows.Forms.Label();
            txtDirector = new System.Windows.Forms.TextBox();
            lbDirector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCartoonList).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lbCartoonID
            // 
            lbCartoonID.AutoSize = true;
            lbCartoonID.Location = new System.Drawing.Point(30, 40);
            lbCartoonID.Name = "lbCartoonID";
            lbCartoonID.Size = new System.Drawing.Size(81, 20);
            lbCartoonID.TabIndex = 0;
            lbCartoonID.Text = "Cartoon ID";
            lbCartoonID.Click += lbCartoonID_Click;
            // 
            // txtCartoonID
            // 
            txtCartoonID.Location = new System.Drawing.Point(149, 36);
            txtCartoonID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCartoonID.Name = "txtCartoonID";
            txtCartoonID.Size = new System.Drawing.Size(210, 27);
            txtCartoonID.TabIndex = 1;
            txtCartoonID.TextChanged += txtCartoonID_TextChanged;
            // 
            // lbCartoonName
            // 
            lbCartoonName.AutoSize = true;
            lbCartoonName.Location = new System.Drawing.Point(30, 95);
            lbCartoonName.Name = "lbCartoonName";
            lbCartoonName.Size = new System.Drawing.Size(106, 20);
            lbCartoonName.TabIndex = 2;
            lbCartoonName.Text = "Cartoon Name";
            // 
            // txtCartoonName
            // 
            txtCartoonName.Location = new System.Drawing.Point(149, 91);
            txtCartoonName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCartoonName.Name = "txtCartoonName";
            txtCartoonName.Size = new System.Drawing.Size(210, 27);
            txtCartoonName.TabIndex = 3;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(30, 148);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(85, 20);
            lbShortDescription.TabIndex = 4;
            lbShortDescription.Text = "Description";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(149, 145);
            txtShortDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new System.Drawing.Size(210, 27);
            txtShortDescription.TabIndex = 5;
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new System.Drawing.Point(434, 95);
            lbActors.Name = "lbActors";
            lbActors.Size = new System.Drawing.Size(51, 20);
            lbActors.TabIndex = 8;
            lbActors.Text = "Actors";
            // 
            // txtActors
            // 
            txtActors.Location = new System.Drawing.Point(510, 91);
            txtActors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtActors.Name = "txtActors";
            txtActors.Size = new System.Drawing.Size(210, 27);
            txtActors.TabIndex = 9;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(434, 149);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(510, 145);
            txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(210, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(70, 198);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(125, 31);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(331, 199);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(125, 31);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(595, 199);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCartoonList
            // 
            dgvCartoonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartoonList.Location = new System.Drawing.Point(30, 396);
            dgvCartoonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCartoonList.Name = "dgvCartoonList";
            dgvCartoonList.ReadOnly = true;
            dgvCartoonList.RowHeadersWidth = 51;
            dgvCartoonList.RowTemplate.Height = 25;
            dgvCartoonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCartoonList.Size = new System.Drawing.Size(1086, 171);
            dgvCartoonList.TabIndex = 15;
            dgvCartoonList.CellDoubleClick += dgvCartoonList_CellDoubleClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(27, 32);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(100, 28);
            txtSearchValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(365, 27);
            txtSearchValue.TabIndex = 17;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new System.Drawing.Point(39, 47);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new System.Drawing.Size(60, 20);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Country";
            // 
            // cboCountry
            // 
            cboCountry.Location = new System.Drawing.Point(115, 44);
            cboCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new System.Drawing.Size(326, 28);
            cboCountry.TabIndex = 0;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(341, 71);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(86, 31);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByActor);
            grSearch.Controls.Add(radioByProducer);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(29, 255);
            grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Size = new System.Drawing.Size(496, 119);
            grSearch.TabIndex = 22;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            grSearch.Enter += grSearch_Enter;
            // 
            // radioByActor
            // 
            radioByActor.AutoSize = true;
            radioByActor.Checked = true;
            radioByActor.Location = new System.Drawing.Point(41, 74);
            radioByActor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            radioByActor.Name = "radioByActor";
            radioByActor.Size = new System.Drawing.Size(86, 24);
            radioByActor.TabIndex = 23;
            radioByActor.TabStop = true;
            radioByActor.Text = "By Actor";
            radioByActor.UseVisualStyleBackColor = true;
            // 
            // radioByProducer
            // 
            radioByProducer.AutoSize = true;
            radioByProducer.Location = new System.Drawing.Point(162, 74);
            radioByProducer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            radioByProducer.Name = "radioByProducer";
            radioByProducer.Size = new System.Drawing.Size(109, 24);
            radioByProducer.TabIndex = 22;
            radioByProducer.TabStop = true;
            radioByProducer.Text = "By Producer";
            radioByProducer.UseVisualStyleBackColor = true;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new System.Drawing.Point(621, 262);
            grFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grFilter.Size = new System.Drawing.Size(495, 112);
            grFilter.TabIndex = 23;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // txtDuration
            // 
            txtDuration.Location = new System.Drawing.Point(906, 144);
            txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new System.Drawing.Size(210, 27);
            txtDuration.TabIndex = 29;
            // 
            // lbDurartion
            // 
            lbDurartion.AutoSize = true;
            lbDurartion.Location = new System.Drawing.Point(787, 148);
            lbDurartion.Name = "lbDurartion";
            lbDurartion.Size = new System.Drawing.Size(67, 20);
            lbDurartion.TabIndex = 28;
            lbDurartion.Text = "Duration";
            // 
            // txtProducer
            // 
            txtProducer.Location = new System.Drawing.Point(906, 90);
            txtProducer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new System.Drawing.Size(210, 27);
            txtProducer.TabIndex = 27;
            // 
            // lbProducer
            // 
            lbProducer.AutoSize = true;
            lbProducer.Location = new System.Drawing.Point(787, 94);
            lbProducer.Name = "lbProducer";
            lbProducer.Size = new System.Drawing.Size(68, 20);
            lbProducer.TabIndex = 26;
            lbProducer.Text = "Producer";
            // 
            // txtCartoonType
            // 
            txtCartoonType.Location = new System.Drawing.Point(906, 35);
            txtCartoonType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCartoonType.Name = "txtCartoonType";
            txtCartoonType.Size = new System.Drawing.Size(210, 27);
            txtCartoonType.TabIndex = 25;
            // 
            // lbCartoonType
            // 
            lbCartoonType.AutoSize = true;
            lbCartoonType.Location = new System.Drawing.Point(787, 39);
            lbCartoonType.Name = "lbCartoonType";
            lbCartoonType.Size = new System.Drawing.Size(95, 20);
            lbCartoonType.TabIndex = 24;
            lbCartoonType.Text = "Cartoon type";
            // 
            // txtLaunchDate
            // 
            txtLaunchDate.Location = new System.Drawing.Point(906, 200);
            txtLaunchDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLaunchDate.Name = "txtLaunchDate";
            txtLaunchDate.Size = new System.Drawing.Size(210, 27);
            txtLaunchDate.TabIndex = 31;
            // 
            // lbLaunchDate
            // 
            lbLaunchDate.AutoSize = true;
            lbLaunchDate.Location = new System.Drawing.Point(787, 204);
            lbLaunchDate.Name = "lbLaunchDate";
            lbLaunchDate.Size = new System.Drawing.Size(91, 20);
            lbLaunchDate.TabIndex = 30;
            lbLaunchDate.Text = "Launch Date";
            lbLaunchDate.Click += label4_Click;
            // 
            // txtDirector
            // 
            txtDirector.Location = new System.Drawing.Point(510, 37);
            txtDirector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new System.Drawing.Size(210, 27);
            txtDirector.TabIndex = 33;
            // 
            // lbDirector
            // 
            lbDirector.AutoSize = true;
            lbDirector.Location = new System.Drawing.Point(434, 39);
            lbDirector.Name = "lbDirector";
            lbDirector.Size = new System.Drawing.Size(63, 20);
            lbDirector.TabIndex = 32;
            lbDirector.Text = "Director";
            // 
            // frmCartoonManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1150, 592);
            Controls.Add(txtDirector);
            Controls.Add(lbDirector);
            Controls.Add(txtLaunchDate);
            Controls.Add(lbLaunchDate);
            Controls.Add(txtDuration);
            Controls.Add(lbDurartion);
            Controls.Add(txtProducer);
            Controls.Add(lbProducer);
            Controls.Add(txtCartoonType);
            Controls.Add(lbCartoonType);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvCartoonList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtActors);
            Controls.Add(lbActors);
            Controls.Add(txtShortDescription);
            Controls.Add(lbShortDescription);
            Controls.Add(txtCartoonName);
            Controls.Add(lbCartoonName);
            Controls.Add(txtCartoonID);
            Controls.Add(lbCartoonID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCartoonManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cartoon Management";
            Load += frmCartoonManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCartoonList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCartoonID;
        private System.Windows.Forms.TextBox txtCartoonID;
        private System.Windows.Forms.Label lbCartoonName;
        private System.Windows.Forms.TextBox txtCartoonName;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lbActors;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCartoonList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByProducer;
        private System.Windows.Forms.RadioButton radioByActor;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lbDurartion;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lbProducer;
        private System.Windows.Forms.TextBox txtCartoonType;
        private System.Windows.Forms.Label lbCartoonType;
        private System.Windows.Forms.TextBox txtLaunchDate;
        private System.Windows.Forms.Label lbLaunchDate;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lbDirector;
    }
}