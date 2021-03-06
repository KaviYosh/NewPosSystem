namespace POS
{
    partial class frmSubCategoryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCategoryAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dGVSubCatDetails = new System.Windows.Forms.DataGridView();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMainCateName = new System.Windows.Forms.Label();
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.txtSubCatName = new System.Windows.Forms.TextBox();
            this.cmbBoxMainCategory = new System.Windows.Forms.ComboBox();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSubCatDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(194)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.pbTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 94);
            this.panel1.TabIndex = 0;
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(213, 14);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(100, 54);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitle.TabIndex = 1;
            this.pbTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.lblTitle.Location = new System.Drawing.Point(311, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sub Category Details";
            // 
            // dGVSubCatDetails
            // 
            this.dGVSubCatDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSubCatDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVSubCatDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSubCatDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatName,
            this.SubName});
            this.dGVSubCatDetails.Location = new System.Drawing.Point(370, 3);
            this.dGVSubCatDetails.Name = "dGVSubCatDetails";
            this.dGVSubCatDetails.RowTemplate.Height = 24;
            this.dGVSubCatDetails.Size = new System.Drawing.Size(485, 605);
            this.dGVSubCatDetails.TabIndex = 5;
            // 
            // CatName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatName.HeaderText = "Main Category Name";
            this.CatName.Name = "CatName";
            // 
            // SubName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubName.HeaderText = "Sub Category Name";
            this.SubName.Name = "SubName";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.lblMainCateName);
            this.panel3.Controls.Add(this.lblSubCategoryName);
            this.panel3.Controls.Add(this.txtSubCatName);
            this.panel3.Controls.Add(this.cmbBoxMainCategory);
            this.panel3.Controls.Add(this.pnPassword);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 606);
            this.panel3.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(200, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Location = new System.Drawing.Point(78, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 45);
            this.btnClear.TabIndex = 5;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblMainCateName
            // 
            this.lblMainCateName.AutoSize = true;
            this.lblMainCateName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCateName.Location = new System.Drawing.Point(15, 29);
            this.lblMainCateName.Name = "lblMainCateName";
            this.lblMainCateName.Size = new System.Drawing.Size(186, 24);
            this.lblMainCateName.TabIndex = 0;
            this.lblMainCateName.Text = "Main Category Name";
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.AutoSize = true;
            this.lblSubCategoryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoryName.Location = new System.Drawing.Point(15, 141);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(174, 24);
            this.lblSubCategoryName.TabIndex = 1;
            this.lblSubCategoryName.Text = "Sub Category Name";
            // 
            // txtSubCatName
            // 
            this.txtSubCatName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSubCatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCatName.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubCatName.Location = new System.Drawing.Point(19, 186);
            this.txtSubCatName.Multiline = true;
            this.txtSubCatName.Name = "txtSubCatName";
            this.txtSubCatName.Size = new System.Drawing.Size(280, 37);
            this.txtSubCatName.TabIndex = 4;
            // 
            // cmbBoxMainCategory
            // 
            this.cmbBoxMainCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxMainCategory.FormattingEnabled = true;
            this.cmbBoxMainCategory.Location = new System.Drawing.Point(19, 82);
            this.cmbBoxMainCategory.Name = "cmbBoxMainCategory";
            this.cmbBoxMainCategory.Size = new System.Drawing.Size(282, 32);
            this.cmbBoxMainCategory.TabIndex = 1;
            this.cmbBoxMainCategory.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMainCategory_SelectedIndexChanged);
            // 
            // pnPassword
            // 
            this.pnPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnPassword.Location = new System.Drawing.Point(19, 229);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(282, 1);
            this.pnPassword.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dGVSubCatDetails);
            this.panel2.Location = new System.Drawing.Point(7, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 614);
            this.panel2.TabIndex = 1;
            // 
            // frmSubCategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubCategoryAdd";
            this.Text = "Add Sub Category Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSubCatDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dGVSubCatDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMainCateName;
        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.TextBox txtSubCatName;
        private System.Windows.Forms.ComboBox cmbBoxMainCategory;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
    }
}