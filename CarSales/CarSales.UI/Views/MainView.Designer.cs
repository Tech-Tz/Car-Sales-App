namespace CarSales.UI.Views
{
    partial class MainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navBar = new System.Windows.Forms.TabControl();
            this.Car = new System.Windows.Forms.TabPage();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.txtSearchCars = new System.Windows.Forms.TextBox();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceCovered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSold = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report = new System.Windows.Forms.TabPage();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarVINSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModelSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.navBar.SuspendLayout();
            this.Car.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navBar.Controls.Add(this.Car);
            this.navBar.Controls.Add(this.Customer);
            this.navBar.Controls.Add(this.Report);
            this.navBar.Location = new System.Drawing.Point(12, 37);
            this.navBar.Name = "navBar";
            this.navBar.SelectedIndex = 0;
            this.navBar.Size = new System.Drawing.Size(1298, 699);
            this.navBar.TabIndex = 0;
            this.navBar.SelectedIndexChanged += new System.EventHandler(this.navBar_SelectedIndexChanged);
            // 
            // Car
            // 
            this.Car.Controls.Add(this.btnSellCar);
            this.Car.Controls.Add(this.btnDeleteCar);
            this.Car.Controls.Add(this.btnEditCar);
            this.Car.Controls.Add(this.btnAddNewCar);
            this.Car.Controls.Add(this.txtSearchCars);
            this.Car.Controls.Add(this.dgCars);
            this.Car.Location = new System.Drawing.Point(4, 29);
            this.Car.Name = "Car";
            this.Car.Padding = new System.Windows.Forms.Padding(3);
            this.Car.Size = new System.Drawing.Size(1290, 666);
            this.Car.TabIndex = 0;
            this.Car.Text = "Cars";
            this.Car.UseVisualStyleBackColor = true;
            // 
            // btnSellCar
            // 
            this.btnSellCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSellCar.Location = new System.Drawing.Point(642, 15);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(148, 46);
            this.btnSellCar.TabIndex = 1;
            this.btnSellCar.Text = "Sell car";
            this.btnSellCar.UseVisualStyleBackColor = true;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCar.Location = new System.Drawing.Point(806, 15);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(148, 46);
            this.btnDeleteCar.TabIndex = 2;
            this.btnDeleteCar.Text = "Delete car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCar.Location = new System.Drawing.Point(971, 15);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(148, 46);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "Edit car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCar.Location = new System.Drawing.Point(1136, 15);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(148, 46);
            this.btnAddNewCar.TabIndex = 4;
            this.btnAddNewCar.Text = "Add new car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // txtSearchCars
            // 
            this.txtSearchCars.Location = new System.Drawing.Point(14, 19);
            this.txtSearchCars.Name = "txtSearchCars";
            this.txtSearchCars.PlaceholderText = "Search by model, year of manufacture, price ...";
            this.txtSearchCars.Size = new System.Drawing.Size(604, 27);
            this.txtSearchCars.TabIndex = 0;
            this.txtSearchCars.TextChanged += new System.EventHandler(this.txtSearchCars_TextChanged);
            // 
            // dgCars
            // 
            this.dgCars.AllowUserToAddRows = false;
            this.dgCars.AllowUserToDeleteRows = false;
            this.dgCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN,
            this.Model,
            this.Manufacturer,
            this.ManufacturedYear,
            this.Id,
            this.Price,
            this.DistanceCovered,
            this.IsSold,
            this.Image,
            this.ImagePath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCars.Location = new System.Drawing.Point(6, 75);
            this.dgCars.MultiSelect = false;
            this.dgCars.Name = "dgCars";
            this.dgCars.ReadOnly = true;
            this.dgCars.RowHeadersWidth = 51;
            this.dgCars.RowTemplate.Height = 200;
            this.dgCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCars.Size = new System.Drawing.Size(1278, 571);
            this.dgCars.TabIndex = 5;
            // 
            // VIN
            // 
            this.VIN.DataPropertyName = "VIN";
            this.VIN.HeaderText = "Vehicle Identification Number";
            this.VIN.MinimumWidth = 6;
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            this.VIN.Width = 200;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 200;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Width = 200;
            // 
            // ManufacturedYear
            // 
            this.ManufacturedYear.DataPropertyName = "ManufacturedYear";
            this.ManufacturedYear.HeaderText = "Manufactured year";
            this.ManufacturedYear.MinimumWidth = 6;
            this.ManufacturedYear.Name = "ManufacturedYear";
            this.ManufacturedYear.ReadOnly = true;
            this.ManufacturedYear.Width = 200;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 200;
            // 
            // DistanceCovered
            // 
            this.DistanceCovered.DataPropertyName = "DistanceCovered";
            this.DistanceCovered.HeaderText = "Distance covered";
            this.DistanceCovered.MinimumWidth = 6;
            this.DistanceCovered.Name = "DistanceCovered";
            this.DistanceCovered.ReadOnly = true;
            this.DistanceCovered.Width = 200;
            // 
            // IsSold
            // 
            this.IsSold.DataPropertyName = "IsSold";
            this.IsSold.HeaderText = "Sold";
            this.IsSold.MinimumWidth = 6;
            this.IsSold.Name = "IsSold";
            this.IsSold.ReadOnly = true;
            this.IsSold.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsSold.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsSold.Width = 200;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 400;
            // 
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "ImagePath";
            this.ImagePath.MinimumWidth = 6;
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Visible = false;
            this.ImagePath.Width = 125;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.btnEdit);
            this.Customer.Controls.Add(this.txtSearchCustomer);
            this.Customer.Controls.Add(this.dgCustomer);
            this.Customer.Location = new System.Drawing.Point(4, 29);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(1290, 666);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customers";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(1156, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 49);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(17, 18);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PlaceholderText = "Search by name, email, phone number";
            this.txtSearchCustomer.Size = new System.Drawing.Size(604, 27);
            this.txtSearchCustomer.TabIndex = 0;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.AllowUserToDeleteRows = false;
            this.dgCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.CustomerEmail,
            this.CustomerPhonenumber});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgCustomer.Location = new System.Drawing.Point(6, 72);
            this.dgCustomer.MultiSelect = false;
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.ReadOnly = true;
            this.dgCustomer.RowHeadersWidth = 51;
            this.dgCustomer.RowTemplate.Height = 29;
            this.dgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomer.Size = new System.Drawing.Size(1278, 588);
            this.dgCustomer.TabIndex = 2;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "Id";
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            this.CustomerId.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 600;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.DataPropertyName = "Email";
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.MinimumWidth = 6;
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            this.CustomerEmail.Width = 400;
            // 
            // CustomerPhonenumber
            // 
            this.CustomerPhonenumber.DataPropertyName = "Phonenumber";
            this.CustomerPhonenumber.HeaderText = "Phone number";
            this.CustomerPhonenumber.MinimumWidth = 6;
            this.CustomerPhonenumber.Name = "CustomerPhonenumber";
            this.CustomerPhonenumber.ReadOnly = true;
            this.CustomerPhonenumber.Width = 300;
            // 
            // Report
            // 
            this.Report.Controls.Add(this.txtFilter);
            this.Report.Controls.Add(this.dgReport);
            this.Report.Location = new System.Drawing.Point(4, 29);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(1290, 666);
            this.Report.TabIndex = 2;
            this.Report.Text = "Sales Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 15);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "Search by employee name";
            this.txtFilter.Size = new System.Drawing.Size(416, 27);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgReport
            // 
            this.dgReport.AllowUserToAddRows = false;
            this.dgReport.AllowUserToDeleteRows = false;
            this.dgReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.EmployeeId,
            this.CarId,
            this.dataGridViewTextBoxColumn1,
            this.CarVINSale,
            this.CarModelSale,
            this.CustomerNameSale,
            this.PurchaseDate,
            this.EmployeeName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgReport.Location = new System.Drawing.Point(6, 60);
            this.dgReport.MultiSelect = false;
            this.dgReport.Name = "dgReport";
            this.dgReport.ReadOnly = true;
            this.dgReport.RowHeadersWidth = 51;
            this.dgReport.RowTemplate.Height = 29;
            this.dgReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReport.Size = new System.Drawing.Size(1278, 600);
            this.dgReport.TabIndex = 1;
            // 
            // SaleId
            // 
            this.SaleId.DataPropertyName = "Id";
            this.SaleId.HeaderText = "Id";
            this.SaleId.MinimumWidth = 6;
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            this.SaleId.Visible = false;
            this.SaleId.Width = 125;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            this.EmployeeId.Width = 125;
            // 
            // CarId
            // 
            this.CarId.DataPropertyName = "CarId";
            this.CarId.HeaderText = "CarId";
            this.CarId.MinimumWidth = 6;
            this.CarId.Name = "CarId";
            this.CarId.ReadOnly = true;
            this.CarId.Visible = false;
            this.CarId.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // CarVINSale
            // 
            this.CarVINSale.DataPropertyName = "VIN";
            this.CarVINSale.HeaderText = "Vehicle identification number";
            this.CarVINSale.MinimumWidth = 6;
            this.CarVINSale.Name = "CarVINSale";
            this.CarVINSale.ReadOnly = true;
            this.CarVINSale.Width = 300;
            // 
            // CarModelSale
            // 
            this.CarModelSale.DataPropertyName = "CarModel";
            this.CarModelSale.HeaderText = "Car model";
            this.CarModelSale.MinimumWidth = 6;
            this.CarModelSale.Name = "CarModelSale";
            this.CarModelSale.ReadOnly = true;
            this.CarModelSale.Width = 300;
            // 
            // CustomerNameSale
            // 
            this.CustomerNameSale.DataPropertyName = "CustomerName";
            this.CustomerNameSale.HeaderText = "Customer";
            this.CustomerNameSale.MinimumWidth = 6;
            this.CustomerNameSale.Name = "CustomerNameSale";
            this.CustomerNameSale.ReadOnly = true;
            this.CustomerNameSale.Width = 300;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Purchase date";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 300;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Sold by (Employee)";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 300;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(1058, 9);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(152, 25);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee name";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 748);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.navBar);
            this.MinimumSize = new System.Drawing.Size(1340, 795);
            this.Name = "MainView";
            this.Text = "XYZ Car Sales System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navBar.ResumeLayout(false);
            this.Car.ResumeLayout(false);
            this.Car.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl navBar;
        private TabPage Car;
        private TabPage Customer;
        private TabPage Report;
        private TextBox txtSearchCars;
        private DataGridView dgCars;
        private Button btnAddNewCar;
        private DataGridView dgCustomer;
        private TextBox txtSearchCustomer;
        private Label lblEmployeeName;
        private Button btnEditCar;
        private Button btnSellCar;
        private Button btnDeleteCar;
        private DataGridViewTextBoxColumn VIN;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn ManufacturedYear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn DistanceCovered;
        private DataGridViewCheckBoxColumn IsSold;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn ImagePath;
        private Button btnEdit;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerEmail;
        private DataGridViewTextBoxColumn CustomerPhonenumber;
        private DataGridView dgReport;
        private TextBox txtFilter;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn CarId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CarVINSale;
        private DataGridViewTextBoxColumn CarModelSale;
        private DataGridViewTextBoxColumn CustomerNameSale;
        private DataGridViewTextBoxColumn PurchaseDate;
        private DataGridViewTextBoxColumn EmployeeName;
    }
}