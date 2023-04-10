using CarSales.UI.Models;
using CarSales.UI.Views;
using CarSales.UI.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales.UI.Views
{
    public partial class CarFormView : BaseView, ICarFormView
    {
        public CarFormView() => InitializeComponent();

        private string _imagePathInput;

        public string FormTitle { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string ManufacturerInput { get => txtManufacturer.Text; set => txtManufacturer.Text = value; }
        public string ManufacturedYearInput { get => txtManufacturedYear.Text; set => txtManufacturedYear.Text = value; }
        public string ModelInput { get => txtModel.Text; set => txtModel.Text = value; }
        public string PriceInput { get => txtPrice.Text; set => txtPrice.Text = value; }
        public string DistanceCoveredInput { get => txtDistanceCovered.Text; set => txtDistanceCovered.Text = value; }
        public string ImagePathInput { 
            get => _imagePathInput; 
            set 
            {
                _imagePathInput = value;
                if (string.IsNullOrWhiteSpace(value)) return;
                CreateImageFromImagePath(pnlImage.Height, pnlImage.Width);

                if (!settingImageFromFileDialog)
                {
                    // Setting image from file dialog takes place in another thread
                    pnlImage.Controls.Clear();
                    pnlImage.Controls.Add(imageControl);
                }
            } 
        }
        public string VINInput { get => txtVIN.Text; set => txtVIN.Text = value; }
        public string FileDialogFilter { get; set; }
        public string FileDialogTitle { get; set; }

        public Action OnSelectImageClicked { get; set; }
        public Action OnImageSelected { get; set; }
        public Action OnCanceled { get; set; }
        public Action OnSubmitted { get; set; }
        public Func<char, bool> OnNumericInputTextChanged { get; set; }

        public void OpenFileDialog()
        {
            int imageHeight = pnlImage.Height;
            int imageWidth = pnlImage.Width;

            settingImageFromFileDialog = true;

            Thread thread = new Thread(() =>
            {
                openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Title = FileDialogTitle,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = FileDialogFilter,
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ImagePathInput = openFileDialog1.FileName;
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            pnlImage.Controls.Clear();
            pnlImage.Controls.Add(imageControl);

            settingImageFromFileDialog = false;
        }

        private bool settingImageFromFileDialog;
        private PictureBox imageControl;

        private void CreateImageFromImagePath(int imageHeight, int imageWidth)
        {
            imageControl = new PictureBox() { Height = imageHeight, Width = imageWidth };
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(() => false);
            Bitmap myBitmap = new Bitmap(ImagePathInput);
            Image myThumbnail = myBitmap.GetThumbnailImage(imageWidth, imageHeight, myCallback, IntPtr.Zero);
            imageControl.Image = myThumbnail;
        }

        private void txtDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnNumericInputTextChanged.Invoke(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCanceled.Invoke();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            OnSubmitted.Invoke();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OnSelectImageClicked.Invoke();
        }

    }
}
