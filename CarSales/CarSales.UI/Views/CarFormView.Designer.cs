namespace CarSales.UI.Views
{
    partial class CarFormView
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
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblManufacturedYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtManufacturedYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtDistanceCovered = new System.Windows.Forms.TextBox();
            this.lblDistanceCovered = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.lblVIN = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManufacturer.Location = new System.Drawing.Point(12, 142);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(127, 25);
            this.lblManufacturer.TabIndex = 0;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblManufacturedYear
            // 
            this.lblManufacturedYear.AutoSize = true;
            this.lblManufacturedYear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManufacturedYear.Location = new System.Drawing.Point(12, 199);
            this.lblManufacturedYear.Name = "lblManufacturedYear";
            this.lblManufacturedYear.Size = new System.Drawing.Size(172, 25);
            this.lblManufacturedYear.TabIndex = 1;
            this.lblManufacturedYear.Text = "Manufactured year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(12, 257);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 25);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(12, 321);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price ($)";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(223, 140);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(474, 27);
            this.txtManufacturer.TabIndex = 1;
            // 
            // txtManufacturedYear
            // 
            this.txtManufacturedYear.Location = new System.Drawing.Point(223, 197);
            this.txtManufacturedYear.Name = "txtManufacturedYear";
            this.txtManufacturedYear.Size = new System.Drawing.Size(474, 27);
            this.txtManufacturedYear.TabIndex = 2;
            this.txtManufacturedYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(223, 258);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(474, 27);
            this.txtModel.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(223, 322);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(474, 27);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // pnlImage
            // 
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Location = new System.Drawing.Point(763, 95);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(372, 317);
            this.pnlImage.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(476, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 32);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Add a new car";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(763, 60);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(107, 29);
            this.btnSelectImage.TabIndex = 6;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(809, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(982, 434);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(153, 45);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtDistanceCovered
            // 
            this.txtDistanceCovered.Location = new System.Drawing.Point(223, 385);
            this.txtDistanceCovered.Name = "txtDistanceCovered";
            this.txtDistanceCovered.Size = new System.Drawing.Size(474, 27);
            this.txtDistanceCovered.TabIndex = 5;
            this.txtDistanceCovered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // lblDistanceCovered
            // 
            this.lblDistanceCovered.AutoSize = true;
            this.lblDistanceCovered.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistanceCovered.Location = new System.Drawing.Point(12, 384);
            this.lblDistanceCovered.Name = "lblDistanceCovered";
            this.lblDistanceCovered.Size = new System.Drawing.Size(198, 25);
            this.lblDistanceCovered.TabIndex = 14;
            this.lblDistanceCovered.Text = "Distance covered (km)";
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(223, 79);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(474, 27);
            this.txtVIN.TabIndex = 0;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVIN.Location = new System.Drawing.Point(12, 81);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(165, 25);
            this.lblVIN.TabIndex = 16;
            this.lblVIN.Text = "Vehicle id number";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CarFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 503);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.lblVIN);
            this.Controls.Add(this.txtDistanceCovered);
            this.Controls.Add(this.lblDistanceCovered);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturedYear);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturedYear);
            this.Controls.Add(this.lblManufacturer);
            this.MaximumSize = new System.Drawing.Size(1174, 550);
            this.MinimumSize = new System.Drawing.Size(1174, 550);
            this.Name = "CarFormView";
            this.Text = "New Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblManufacturer;
        private Label lblManufacturedYear;
        private Label lblModel;
        private Label lblPrice;
        private TextBox txtManufacturer;
        private TextBox txtManufacturedYear;
        private TextBox txtModel;
        private TextBox txtPrice;
        private Panel pnlImage;
        private Label lblTitle;
        private Button btnSelectImage;
        private Button btnCancel;
        private Button btnValidate;
        private TextBox txtDistanceCovered;
        private Label lblDistanceCovered;
        private TextBox txtVIN;
        private Label lblVIN;
        private OpenFileDialog openFileDialog1;
    }
}