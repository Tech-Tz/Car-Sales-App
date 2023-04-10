using CarSales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Repositories
{
    public interface ICarRepository : IRepository<CarEntity>
    {
        IEnumerable<CarEntity> GetByManufacturer(string manufacturer);
        IEnumerable<CarEntity> GetByPurchaseDate(DateTime purchaseDate);
        IEnumerable<CarEntity> GetByPurchaseDateGreaterThan(DateTime purchaseDate);
        IEnumerable<CarEntity> GetByPurchaseDateLessThan(DateTime purchaseDate);
        IEnumerable<CarEntity> GetByPrice(decimal price);
        IEnumerable<CarEntity> GetByPriceGreaterThan(decimal price);
        IEnumerable<CarEntity> GetByPriceLessThan(decimal price);
        IEnumerable<CarEntity> GetByModel(string model);
        IEnumerable<CarEntity> GetUsedCars();
        IEnumerable<CarEntity> GetUnusedCars();
        IEnumerable<CarEntity> GetByDistanceCovered(decimal distanceCovered);
        IEnumerable<CarEntity> GetByDistanceCoveredGreaterThan(decimal distanceCovered);
        IEnumerable<CarEntity> GetByDistanceCoveredLessThan(decimal distanceCovered);
        IEnumerable<CarEntity> GetSoldCars();
        CarEntity GetByVIN(string VIN);

        string SaveCarImage(string imagePath);
    }
}
