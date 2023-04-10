using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Entities
{
    public class CarEntity : IEntity
    {
        public int? Id { get; set; }

        public string VIN { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int ManufacturedYear { get; set; }

        public decimal Price { get; set; }

        public bool HasBeenUsed { get => DistanceCovered.HasValue; }

        public decimal? DistanceCovered { get; set; }

        public string ImagePath { get; set; }

        public CarEntity() { }

        public CarEntity(string VIN,
            string model,
            string manufacturer,
            int manufacturedYear,
            decimal price,
            decimal? distanceCovered,
            string imagePath)
        {
            this.VIN = VIN;
            Model = model;
            Manufacturer = manufacturer;
            ManufacturedYear = manufacturedYear;
            Price = price;
            DistanceCovered = distanceCovered;
            ImagePath = imagePath;
        }
    }
}
