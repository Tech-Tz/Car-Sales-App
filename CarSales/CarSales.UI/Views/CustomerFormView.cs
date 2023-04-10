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
    public partial class CustomerFormView : BaseView, ICustomerFormView
    {
        public CustomerFormView()
        {
            InitializeComponent();
        }

        public string CustomerNameInput { get => txtCustomerName.Text; set => txtCustomerName.Text = value; }
        public string CustomerEmailInput { get => txtCustomerEmail.Text; set => txtCustomerEmail.Text = value; }
        public string CustomerPhoneInput { get => txtCustomerPhone.Text; set => txtCustomerPhone.Text = value; }
        public Action OnSubmitted { get; set; }
        public Action OnCanceled { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCanceled.Invoke();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            OnSubmitted.Invoke();
        }
    }
}
