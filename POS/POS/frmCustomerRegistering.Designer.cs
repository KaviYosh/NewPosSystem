namespace POS
{
    partial class frmCustomerRegistering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRegistering));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVCustomerDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustStreetAddLine2 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCustMobileNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustStreetAddLine2 = new System.Windows.Forms.Label();
            this.txtCustStreetAddress = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblCustPersonalMobilNo = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCustStreetAddress = new System.Windows.Forms.Label();
            this.txtCustUserNICNo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCustNicNo = new System.Windows.Forms.Label();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCustFirstName = new System.Windows.Forms.Label();
            this.lblCustLastName = new System.Windows.Forms.Label();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCustomerDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(194)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.pbTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 94);
            this.panel1.TabIndex = 2;
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(469, 18);
            this.pbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblTitle.Location = new System.Drawing.Point(565, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customers Registration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dGVCustomerDetails);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(11, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 617);
            this.panel2.TabIndex = 3;
            // 
            // dGVCustomerDetails
            // 
            this.dGVCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.NIC,
            this.AddressLine_1,
            this.AddressLine_2,
            this.TeleNo});
            this.dGVCustomerDetails.Location = new System.Drawing.Point(395, 2);
            this.dGVCustomerDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVCustomerDetails.Name = "dGVCustomerDetails";
            this.dGVCustomerDetails.RowTemplate.Height = 24;
            this.dGVCustomerDetails.Size = new System.Drawing.Size(827, 596);
            this.dGVCustomerDetails.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtCustStreetAddLine2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.txtCustMobileNo);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.lblCustStreetAddLine2);
            this.panel3.Controls.Add(this.txtCustStreetAddress);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.lblCustPersonalMobilNo);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.lblCustStreetAddress);
            this.panel3.Controls.Add(this.txtCustUserNICNo);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblCustNicNo);
            this.panel3.Controls.Add(this.txtCustLastName);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblCustFirstName);
            this.panel3.Controls.Add(this.lblCustLastName);
            this.panel3.Controls.Add(this.txtCustFirstName);
            this.panel3.Controls.Add(this.pnPassword);
            this.panel3.Location = new System.Drawing.Point(5, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 596);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtCustStreetAddLine2
            // 
            this.txtCustStreetAddLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCustStreetAddLine2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustStreetAddLine2.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustStreetAddLine2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustStreetAddLine2.Location = new System.Drawing.Point(19, 340);
            this.txtCustStreetAddLine2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustStreetAddLine2.Multiline = true;
            this.txtCustStreetAddLine2.Name = "txtCustStreetAddLine2";
            this.txtCustStreetAddLine2.Size = new System.Drawing.Size(331, 30);
            this.txtCustStreetAddLine2.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(19, 377);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(331, 1);
            this.panel8.TabIndex = 19;
            // 
            // txtCustMobileNo
            // 
            this.txtCustMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCustMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustMobileNo.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustMobileNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustMobileNo.Location = new System.Drawing.Point(19, 421);
            this.txtCustMobileNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustMobileNo.Multiline = true;
            this.txtCustMobileNo.Name = "txtCustMobileNo";
            this.txtCustMobileNo.Size = new System.Drawing.Size(331, 30);
            this.txtCustMobileNo.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(236, 518);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Location = new System.Drawing.Point(107, 518);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 52);
            this.btnClear.TabIndex = 7;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCustStreetAddLine2
            // 
            this.lblCustStreetAddLine2.AutoSize = true;
            this.lblCustStreetAddLine2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustStreetAddLine2.Location = new System.Drawing.Point(15, 309);
            this.lblCustStreetAddLine2.Name = "lblCustStreetAddLine2";
            this.lblCustStreetAddLine2.Size = new System.Drawing.Size(186, 24);
            this.lblCustStreetAddLine2.TabIndex = 18;
            this.lblCustStreetAddLine2.Text = "Street Address Line 2";
            // 
            // txtCustStreetAddress
            // 
            this.txtCustStreetAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCustStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustStreetAddress.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustStreetAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustStreetAddress.Location = new System.Drawing.Point(19, 262);
            this.txtCustStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustStreetAddress.Multiline = true;
            this.txtCustStreetAddress.Name = "txtCustStreetAddress";
            this.txtCustStreetAddress.Size = new System.Drawing.Size(331, 30);
            this.txtCustStreetAddress.TabIndex = 4;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel13.Location = new System.Drawing.Point(21, 460);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(331, 1);
            this.panel13.TabIndex = 16;
            // 
            // lblCustPersonalMobilNo
            // 
            this.lblCustPersonalMobilNo.AutoSize = true;
            this.lblCustPersonalMobilNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPersonalMobilNo.Location = new System.Drawing.Point(15, 386);
            this.lblCustPersonalMobilNo.Name = "lblCustPersonalMobilNo";
            this.lblCustPersonalMobilNo.Size = new System.Drawing.Size(184, 24);
            this.lblCustPersonalMobilNo.TabIndex = 15;
            this.lblCustPersonalMobilNo.Text = "Customer Mobile No";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(19, 298);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 1);
            this.panel7.TabIndex = 16;
            // 
            // lblCustStreetAddress
            // 
            this.lblCustStreetAddress.AutoSize = true;
            this.lblCustStreetAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustStreetAddress.Location = new System.Drawing.Point(17, 235);
            this.lblCustStreetAddress.Name = "lblCustStreetAddress";
            this.lblCustStreetAddress.Size = new System.Drawing.Size(132, 24);
            this.lblCustStreetAddress.TabIndex = 15;
            this.lblCustStreetAddress.Text = "Street Address";
            // 
            // txtCustUserNICNo
            // 
            this.txtCustUserNICNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCustUserNICNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustUserNICNo.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustUserNICNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustUserNICNo.Location = new System.Drawing.Point(19, 187);
            this.txtCustUserNICNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustUserNICNo.Multiline = true;
            this.txtCustUserNICNo.Name = "txtCustUserNICNo";
            this.txtCustUserNICNo.Size = new System.Drawing.Size(331, 30);
            this.txtCustUserNICNo.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(21, 222);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 1);
            this.panel5.TabIndex = 10;
            // 
            // lblCustNicNo
            // 
            this.lblCustNicNo.AutoSize = true;
            this.lblCustNicNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNicNo.Location = new System.Drawing.Point(15, 160);
            this.lblCustNicNo.Name = "lblCustNicNo";
            this.lblCustNicNo.Size = new System.Drawing.Size(154, 24);
            this.lblCustNicNo.TabIndex = 9;
            this.lblCustNicNo.Text = "Customer NIC No";
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCustLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustLastName.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustLastName.Location = new System.Drawing.Point(19, 111);
            this.txtCustLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustLastName.Multiline = true;
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(331, 30);
            this.txtCustLastName.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(23, 146);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 1);
            this.panel4.TabIndex = 7;
            // 
            // lblCustFirstName
            // 
            this.lblCustFirstName.AutoSize = true;
            this.lblCustFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFirstName.Location = new System.Drawing.Point(15, 6);
            this.lblCustFirstName.Name = "lblCustFirstName";
            this.lblCustFirstName.Size = new System.Drawing.Size(100, 24);
            this.lblCustFirstName.TabIndex = 0;
            this.lblCustFirstName.Text = "First Name";
            // 
            // lblCustLastName
            // 
            this.lblCustLastName.AutoSize = true;
            this.lblCustLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustLastName.Location = new System.Drawing.Point(15, 84);
            this.lblCustLastName.Name = "lblCustLastName";
            this.lblCustLastName.Size = new System.Drawing.Size(97, 24);
            this.lblCustLastName.TabIndex = 1;
            this.lblCustLastName.Text = "Last Name";
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCustFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustFirstName.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustFirstName.Location = new System.Drawing.Point(21, 33);
            this.txtCustFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustFirstName.Multiline = true;
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(331, 30);
            this.txtCustFirstName.TabIndex = 1;
            this.txtCustFirstName.TextChanged += new System.EventHandler(this.txtCustFirstName_TextChanged);
            // 
            // pnPassword
            // 
            this.pnPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnPassword.Location = new System.Drawing.Point(21, 66);
            this.pnPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(331, 1);
            this.pnPassword.TabIndex = 3;
            // 
            // FirstName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle2;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.DefaultCellStyle = dataGridViewCellStyle3;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // NIC
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC.DefaultCellStyle = dataGridViewCellStyle4;
            this.NIC.HeaderText = "NIC";
            this.NIC.Name = "NIC";
            // 
            // AddressLine_1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine_1.DefaultCellStyle = dataGridViewCellStyle5;
            this.AddressLine_1.HeaderText = "Address Line 1";
            this.AddressLine_1.Name = "AddressLine_1";
            // 
            // AddressLine_2
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine_2.DefaultCellStyle = dataGridViewCellStyle6;
            this.AddressLine_2.HeaderText = "Address Line 2";
            this.AddressLine_2.Name = "AddressLine_2";
            // 
            // TeleNo
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.TeleNo.HeaderText = "Tele No";
            this.TeleNo.Name = "TeleNo";
            // 
            // frmCustomerRegistering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCustomerRegistering";
            this.Text = "Customers Registering";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCustomerDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustMobileNo;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblCustPersonalMobilNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustStreetAddLine2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCustStreetAddLine2;
        private System.Windows.Forms.TextBox txtCustStreetAddress;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCustStreetAddress;
        private System.Windows.Forms.TextBox txtCustUserNICNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCustNicNo;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCustFirstName;
        private System.Windows.Forms.Label lblCustLastName;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.DataGridView dGVCustomerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeleNo;
    }
}