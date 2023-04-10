using CarSales.Core.Entities;
using CarSales.UI.Enums;
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
    /// <summary>
    /// Main view consisting of the tabs : Cars, Customers and Report
    /// </summary>
    public partial class MainView : BaseView, IMainView
    {
        public MainView() => InitializeComponent();

        public Action<TabChangedEvent> OnTabChanged { get; set; }
        public MainViewTab DefaultTab { set => navBar.SelectedIndex = (int)value; }

        public string EmployeeLoggedinText { set => lblEmployeeName.Text = value; }

        private void navBar_SelectedIndexChanged(object sender, EventArgs e)
            => OnTabChanged.Invoke(new TabChangedEvent((MainViewTab)navBar.SelectedIndex));
    }

    /// <summary>
    /// Main view consisting of the first tab : Cars
    /// </summary>
    public partial class MainView : ICarListView
    {
        public IEnumerable<CarModel> Cars { set => this.dgCars.DataSource = value; }

        public Action OnAddNewCarClicked { get; set; }
        public Action<SearchedCarEvent> OnSearchedCars { get; set; }
        public Action<EditCarClickedEvent> OnEditCarClicked { get; set; }
        public Action<DeleteCarClickedEvent> OnDeleteCarClicked { get; set; }
        public Action<SellCarClickedEvent> OnSellCarClicked { get; set; }

        private void txtSearchCars_TextChanged(object sender, EventArgs e)
            => OnSearchedCars?.Invoke(new SearchedCarEvent(txtSearchCars.Text));

        private void btnAddNewCar_Click(object sender, EventArgs e)
            => OnAddNewCarClicked?.Invoke();

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var currentRow = dgCars.CurrentRow;
            var carModel = new CarModel(
                (int)currentRow.Cells["Id"].Value,
                (string)currentRow.Cells["VIN"].Value,
                (string)currentRow.Cells["Model"].Value,
                (string)currentRow.Cells["Manufacturer"].Value,
                (string)currentRow.Cells["ManufacturedYear"].Value,
                (decimal)currentRow.Cells["Price"].Value,
                (decimal?)currentRow.Cells["DistanceCovered"].Value,
                (bool)currentRow.Cells["IsSold"].Value,
                (Bitmap)currentRow.Cells["Image"].Value,
                (string)currentRow.Cells["ImagePath"].Value
                );
            OnEditCarClicked?.Invoke(new EditCarClickedEvent(carModel));
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
            => OnDeleteCarClicked.Invoke(new DeleteCarClickedEvent((int)dgCars.CurrentRow.Cells["Id"].Value));

        private void btnSellCar_Click(object sender, EventArgs e)
            => OnSellCarClicked.Invoke(new SellCarClickedEvent((int)dgCars.CurrentRow.Cells["Id"].Value, (string)dgCars.CurrentRow.Cells["VIN"].Value));
    }

    /// <summary>
    /// Main view consisting of the second tab : Customers
    /// </summary>
    public partial class MainView : ICustomerListView
    {
        public IEnumerable<CustomerModel> Customers { set => this.dgCustomer.DataSource = value; }

        public Action<SearchedCustomerEvent> OnSearchedCustomers { get; set; }
        public Action<EditCustomerClickedEvent> OnEditCustomerClicked { get; set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var currentRow = dgCustomer.CurrentRow;
            var customerModel = new CustomerModel(
                (int)currentRow.Cells["CustomerId"].Value,
                (string)currentRow.Cells["CustomerName"].Value,
                (string)currentRow.Cells["CustomerEmail"].Value,
                (string)currentRow.Cells["CustomerPhonenumber"].Value);
            OnEditCustomerClicked.Invoke(new EditCustomerClickedEvent(customerModel));
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
            => OnSearchedCustomers?.Invoke(new SearchedCustomerEvent(txtSearchCustomer.Text));
    }

    /// <summary>
    /// Main view consisting of the third tab : Report
    /// </summary>
    public partial class MainView : ISaleListView
    {
        public IEnumerable<SaleModel> Sales { set => dgReport.DataSource = value; }
        public Action<SearchedSaleEvent> OnSearchedSales { get; set; }

        private void txtFilter_TextChanged(object sender, EventArgs e)
            => OnSearchedSales.Invoke(new SearchedSaleEvent(txtFilter.Text));
    }
}
