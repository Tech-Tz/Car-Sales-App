using CarSales.UI.Events;
using CarSales.UI.Models;
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
    public partial class NewSaleFormView : BaseView, INewSaleFormView
    {
        public NewSaleFormView()
        {
            InitializeComponent();
        }

        public string VIN { set => this.lblVINData.Text = value; }
        public IEnumerable<CustomerModel> Customers { set => cbCustomers.DataSource = value; }
        public string CustomerNameInput { get => txtCustomerName.Text; set => txtCustomerName.Text = value; }
        public string CustomerEmailInput { get => txtCustomerEmail.Text; set => txtCustomerEmail.Text = value; }
        public string CustomerPhoneInput { get => txtCustomerPhone.Text; set => txtCustomerPhone.Text = value; }
        public bool EnableCustomerNameInput { set => txtCustomerName.Enabled = value; }
        public bool EnableCustomerEmailInput { set => txtCustomerEmail.Enabled = value; }
        public bool EnableCustomerPhoneInput { set => txtCustomerPhone.Enabled = value; }
        public bool NewCustomer { get => !chkExistingCustomer.Checked; }
        public bool EnableCustomerDropdown { set => cbCustomers.Enabled = value; }
        public int DropdownSelectedCustomerId { set => cbCustomers.SelectedValue = value; }

        public Action<CustomerSelectionOptionClickedEvent> OnCustomerSelectionOptionClicked { get; set; }
        public Action<CustomerSelectedEvent> OnCustomerSelected { get; set; }
        public Action OnValidateSaleClicked { get; set; }
        public Action OnCancelSaleClicked { get; set; }

        private void chkExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            OnCustomerSelectionOptionClicked.Invoke(new CustomerSelectionOptionClickedEvent(chkExistingCustomer.Checked));
        }

        private void cbCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCustomers.SelectedValue == null || (int)cbCustomers.SelectedValue == 0)
                return;
            OnCustomerSelected.Invoke(new CustomerSelectedEvent((CustomerModel)cbCustomers.SelectedItem));
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            OnValidateSaleClicked.Invoke();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelSaleClicked.Invoke();
        }
    }
}
