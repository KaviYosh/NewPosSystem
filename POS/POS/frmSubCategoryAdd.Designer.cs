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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMainCateName = new System.Windows.Forms.Label();
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.cmbBoxMainCategory = new System.Windows.Forms.ComboBox();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // pbTitle
            // 
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(159, 24);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(100, 54);
            this.pbTitle.TabIndex = 1;
            this.pbTitle.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.pnPassword);
            this.panel2.Controls.Add(this.cmbBoxMainCategory);
            this.panel2.Controls.Add(this.lblSubCategoryName);
            this.panel2.Controls.Add(this.lblMainCateName);
            this.panel2.Location = new System.Drawing.Point(7, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 614);
            this.panel2.TabIndex = 1;
            // 
            // lblMainCateName
            // 
            this.lblMainCateName.AutoSize = true;
            this.lblMainCateName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCateName.Location = new System.Drawing.Point(35, 50);
            this.lblMainCateName.Name = "lblMainCateName";
            this.lblMainCateName.Size = new System.Drawing.Size(186, 24);
            this.lblMainCateName.TabIndex = 0;
            this.lblMainCateName.Text = "Main Category Name";
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.AutoSize = true;
            this.lblSubCategoryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoryName.Location = new System.Drawing.Point(35, 162);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(174, 24);
            this.lblSubCategoryName.TabIndex = 1;
            this.lblSubCategoryName.Text = "Sub Category Name";
            // 
            // cmbBoxMainCategory
            // 
            this.cmbBoxMainCategory.FormattingEnabled = true;
            this.cmbBoxMainCategory.Location = new System.Drawing.Point(39, 103);
            this.cmbBoxMainCategory.Name = "cmbBoxMainCategory";
            this.cmbBoxMainCategory.Size = new System.Drawing.Size(270, 24);
            this.cmbBoxMainCategory.TabIndex = 1;
            this.cmbBoxMainCategory.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMainCategory_SelectedIndexChanged);
            // 
            // pnPassword
            // 
            this.pnPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnPassword.Location = new System.Drawing.Point(39, 250);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(282, 1);
            this.pnPassword.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(39, 207);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 37);
            this.txtPassword.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 239);
            this.dataGridView1.TabIndex = 5;
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
            this.Text = "frmSubCategoryAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBoxMainCategory;
        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.Label lblMainCateName;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}