using CarSales.Core.Entities;
using CarSales.Core.Repositories;
using CarSales.UI.Models;
using CarSales.UI.Validators;
using CarSales.UI.Views.Interfaces;
using CarSales.UI.ViewsParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Controllers
{
    public class CarFormController : BaseController<ICarFormView, CarFormViewParam>
    {
        private readonly ICarRepository _carRepository = RepositoryFactory.GetCarRepository();

        public CarFormController(ICarFormView carFormView, 
            IViewActivator viewActivator, 
            IViewDeactivator viewDeactivator,
            CarFormViewParam carFormViewParam) : base(carFormView, viewActivator, viewDeactivator, carFormViewParam)
        {
            View.OnViewShown = ShownHandler;
            View.OnCanceled = CanceledHandler;
            View.OnSelectImageClicked = SelectImageClickedHandler;
            View.OnSubmitted = SubmittedHandler;
            View.OnNumericInputTextChanged = NumericInputTextChangedHandler;
        }

        private bool NumericInputTextChangedHandler(char c)
        {
            return !char.IsControl(c) && !char.IsDigit(c);
        }

        private void ShownHandler()
        {
            View.ManufacturerInput = ViewParameter.Manufacturer;
            View.ManufacturedYearInput = ViewParameter.ManufacturedYear != 0 ? ViewParameter.ManufacturedYear.ToString() : null;
            View.PriceInput = ViewParameter.Price != decimal.Zero ? ViewParameter.Price.ToString() : null;
            View.ModelInput = ViewParameter.Model;
            View.DistanceCoveredInput = ViewParameter.DistanceCovered.HasValue
                ? ViewParameter.DistanceCovered.Value.ToString()
                : string.Empty;
            View.VINInput = ViewParameter.VIN;
            View.FileDialogFilter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            View.FileDialogTitle = "Select photo";
            View.ImagePathInput = ViewParameter.ImagePath;
            View.FormTitle = ViewParameter.IsNewCar ? "Add new car" : "Edit car";
        }

        private void CanceledHandler() => ViewDeactivator.Deactivate(this);

        private void SelectImageClickedHandler() => View.OpenFileDialog();

        private void SubmittedHandler() 
        {
            if (!ValidateInputs())
                return;

            string saveImagePath = _carRepository.SaveCarImage(View.ImagePathInput);

            if (_carRepository.GetByVIN(View.VINInput) != null)
            {
                if (ViewParameter.IsNewCar || View.VINInput != ViewParameter.VIN)
                {
                    View.ShowMessage("A car with the same VIN already exists!");
                    return;
                }
            }

            CarEntity car = new CarEntity(View.VINInput,
                View.ModelInput, 
                View.ManufacturerInput, 
                int.Parse(View.ManufacturedYearInput),
                decimal.Parse(View.PriceInput),
                string.IsNullOrWhiteSpace(View.DistanceCoveredInput) ? null : decimal.Parse(View.DistanceCoveredInput),
                saveImagePath);

            if (ViewParameter.IsNewCar)
                _carRepository.Add(car);
            else
            {
                car.Id = ViewParameter.Id.Value;
                _carRepository.Update(car);
            }

            // Reload car list view to show new/updated car in the list
            ViewDeactivator.Deactivate(this);
            ViewActivator.Activate<ICarListView, CarListViewParam>(new CarListViewParam(ViewParameter.EmployeeId));
        }

        private bool ValidateInputs()
        {
            if (!CarValidator.IsVINValid(View.VINInput))
            {
                View.ShowMessage(CarValidator.VehicleIdNumberInvalid);
                return false;
            }
            else if (!CarValidator.IsManufacturerInputValid(View.ManufacturerInput))
            {
                View.ShowMessage(CarValidator.ManufacturerInvalid);
                return false;
            }
            else if (!CarValidator.IsManufacturedYearInputValid(View.ManufacturedYearInput))
            {
                View.ShowMessage(CarValidator.ManufacturedYearInvalid);
                return false;
            }
            else if (!CarValidator.IsModelInputValid(View.ModelInput))
            {
                View.ShowMessage(CarValidator.ModelInvalid);
                return false;
            }
            else if (!CarValidator.IsPriceInputValid(View.PriceInput))
            {
                View.ShowMessage(CarValidator.PriceInvalid);
                return false;
            }
            else if (!CarValidator.IsDistanceCoveredValid(View.DistanceCoveredInput))
            {
                View.ShowMessage(CarValidator.DistanceCoveredInvalid);
                return false;
            }
            else return true;
        }
    }
}
