using CarSales.Core.Repositories;
using CarSales.UI.Events;
using CarSales.UI.Models;
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
    public class CarListController : BaseController<ICarListView, CarListViewParam>
    {
        private readonly ICarRepository _carRepository = RepositoryFactory.GetCarRepository();
        private IEnumerable<CarModel> _cachedCars;

        public CarListController(ICarListView carListView, 
            IViewActivator viewNavigator,
            IViewDeactivator viewDeactivator,
            CarListViewParam viewParam) : base(carListView, viewNavigator, viewDeactivator, viewParam)
        {
            View.OnSearchedCars = SearchedCarHandler;
            View.OnAddNewCarClicked = AddNewCarClickedHandler;
            View.OnEditCarClicked = EditCarClickedHandler;
            View.OnDeleteCarClicked = DeleteCarClickedHandler;
            View.OnSellCarClicked = SellCarClickedHandler;

            DisplayCars();
        }

        private IEnumerable<CarModel> GetCars()
        {
            var cars = _carRepository.GetAll();
            var soldCars = _carRepository.GetSoldCars();
            return cars.Select(c =>
            {
                bool isCarSold = soldCars.Any(sc => sc.Id == c.Id);
                Bitmap carImage = null;
                if (!string.IsNullOrWhiteSpace(c.ImagePath))
                    carImage = new Bitmap(c.ImagePath);
                return new CarModel(
                    c.Id.Value,
                    c.VIN,
                    c.Model,
                    c.Manufacturer,
                    c.ManufacturedYear.ToString(),
                    c.Price,
                    c.DistanceCovered,
                    isCarSold,
                    carImage,
                    c.ImagePath);
            });
        }

        private void DisplayCars() 
        {
            _cachedCars = GetCars();
            View.Cars = _cachedCars.ToList(); 
        }

        private void SearchedCarHandler(SearchedCarEvent searchEvent)
        {
            if (string.IsNullOrWhiteSpace(searchEvent.SearchText))
                View.Cars = _cachedCars.ToList();
            else
            {
                View.Cars = _cachedCars.Where(c =>
                {
                    return
                        c.Manufacturer.ToLower().Contains(searchEvent.SearchText.ToLower()) ||
                        c.ManufacturedYear.ToString().ToLower().Contains(searchEvent.SearchText.ToLower()) ||
                        c.Price.ToString().ToLower().Contains(searchEvent.SearchText.ToLower()) ||
                        (c.DistanceCovered.HasValue ? c.DistanceCovered.Value.ToString().ToLower().Contains(searchEvent.SearchText.ToLower()) : false) ||
                        c.Model.ToLower().Contains(searchEvent.SearchText.ToLower()) ||
                        c.VIN.ToLower().Contains(searchEvent.SearchText.ToLower());
                }).ToList();
            }
        }

        private void AddNewCarClickedHandler() 
        { 
            ViewActivator.ActivateModal<ICarFormView, CarFormViewParam>(new CarFormViewParam(true, ViewParameter.EmployeeId)); 
        }

        private void EditCarClickedHandler(EditCarClickedEvent editCarClickedEvent)
        {
            if (_carRepository.GetSoldCars().Any(c => c.Id == editCarClickedEvent.Car.Id))
            {
                View.ShowMessage("This car is already sold. It cannot be edited!");
                return;
            }
            ViewActivator.ActivateModal<ICarFormView, CarFormViewParam>(new CarFormViewParam(false, ViewParameter.EmployeeId) 
            {
                Manufacturer = editCarClickedEvent.Car.Manufacturer,
                ManufacturedYear = int.Parse(editCarClickedEvent.Car.ManufacturedYear),
                Model = editCarClickedEvent.Car.Model,
                Price = editCarClickedEvent.Car.Price,
                DistanceCovered = editCarClickedEvent.Car.DistanceCovered,
                ImagePath = editCarClickedEvent.Car.ImagePath,
                VIN = editCarClickedEvent.Car.VIN,
                Id = editCarClickedEvent.Car.Id
            });
        }

        private void DeleteCarClickedHandler(DeleteCarClickedEvent deleteCarClickedEvent)
        {
            if (_carRepository.GetSoldCars().Any(c => c.Id == deleteCarClickedEvent.CarId))
            {
                View.ShowMessage("This car is already sold. It cannot be deleted!");
                return;
            }
            _carRepository.Delete(deleteCarClickedEvent.CarId);
            DisplayCars();
        }

        private void SellCarClickedHandler(SellCarClickedEvent sellCarClickedEvent)
        {
            if (_carRepository.GetSoldCars().Any(c => c.Id == sellCarClickedEvent.CarId))
            {
                View.ShowMessage("This car is already sold!");
                return;
            }
            
            ViewActivator.ActivateModal<INewSaleFormView, NewSaleFormViewParam>(new NewSaleFormViewParam(
                sellCarClickedEvent.CarId, sellCarClickedEvent.VIN, ViewParameter.EmployeeId));

            DisplayCars();
        }
    }
}
