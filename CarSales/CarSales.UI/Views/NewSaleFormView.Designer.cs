namespace CarSales.UI.Views
{
    partial class NewSaleFormView
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
            this.components = new System.ComponentModel.Container();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblVINData = new System.Windows.Forms.Label();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.chkExistingCustomer = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVIN.Location = new System.Drawing.Point(25, 80);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(274, 25);
            this.lblVIN.TabIndex = 0;
            this.lblVIN.Text = "Vehicle identification number : ";
            // 
            // lblVINData
            // 
            this.lblVINData.AutoSize = true;
            this.lblVINData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVINData.Location = new System.Drawing.Point(305, 80);
            this.lblVINData.Name = "lblVINData";
            this.lblVINData.Size = new System.Drawing.Size(51, 25);
            this.lblVINData.TabIndex = 1;
            this.lblVINData.Text = "Data";
            // 
            // cbCustomers
            // 
            this.cbCustomers.DisplayMember = "Name";
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(260, 137);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(151, 28);
            this.cbCustomers.TabIndex = 1;
            this.cbCustomers.ValueMember = "Id";
            this.cbCustomers.SelectedValueChanged += new System.EventHandler(this.cbCustomers_SelectedValueChanged);
            // 
            // chkExistingCustomer
            // 
            this.chkExistingCustomer.AutoSize = true;
            this.chkExistingCustomer.Location = new System.Drawing.Point(34, 141);
            this.chkExistingCustomer.Name = "chkExistingCustomer";
            this.chkExistingCustomer.Size = new System.Drawing.Size(220, 24);
            this.chkExistingCustomer.TabIndex = 0;
            this.chkExistingCustomer.Text = "Choose an existing customer";
            this.chkExistingCustomer.UseVisualStyleBackColor = true;
            this.chkExistingCustomer.CheckedChanged += new System.EventHandler(this.chkExistingCustomer_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(343, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "New car sale";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.Location = new System.Drawing.Point(8, 26);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(145, 25);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Customer name";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerEmail.Location = new System.Drawing.Point(9, 81);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(144, 25);
            this.lblCustomerEmail.TabIndex = 6;
            this.lblCustomerEmail.Text = "Customer email";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerPhone.Location = new System.Drawing.Point(8, 138);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(223, 25);
            this.lblCustomerPhone.TabIndex = 7;
            this.lblCustomerPhone.Text = "Customer phone number";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.txtCustomerPhone);
            this.pnlCustomer.Controls.Add(this.txtCustomerEmail);
            this.pnlCustomer.Controls.Add(this.txtCustomerName);
            this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Controls.Add(this.lblCustomerPhone);
            this.pnlCustomer.Controls.Add(this.lblCustomerEmail);
            this.pnlCustomer.Location = new System.Drawing.Point(25, 212);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(763, 209);
            this.pnlCustomer.TabIndex = 8;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(279, 138);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(468, 27);
            this.txtCustomerPhone.TabIndex = 4;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(279, 82);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(468, 27);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(279, 24);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(468, 27);
            this.txtCustomerName.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(615, 452);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(140, 59);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(443, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 59);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewSaleFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkExistingCustomer);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.lblVINData);
            this.Controls.Add(this.lblVIN);
            this.MaximumSize = new System.Drawing.Size(818, 570);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "NewSaleFormView";
            this.Text = "New car sale";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVIN;
        private Label lblVINData;
        private ComboBox cbCustomers;
        private CheckBox chkExistingCustomer;
        private Label lblTitle;
        private Label lblCustomerName;
        private Label lblCustomerEmail;
        private Label lblCustomerPhone;
        private BindingSource bindingSource1;
        private Panel pnlCustomer;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerName;
        private Button btnValidate;
        private Button btnCancel;
    }
}