using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Models
{
    public class CarModel
    {
        public int Id { get; set; }

        public string VIN { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string ManufacturedYear { get; set; }

        public decimal Price { get; set; }

        public decimal? DistanceCovered { get; set; }

        public bool IsSold { get; set; }

        public Bitmap Image { get; set; }

        public string ImagePath { get; set; }

        public CarModel(
            int id,
            string VIN,
            string model, 
            string manufacturer,
            string manufacturedYear,
            decimal price,
            decimal? distanceCovered,
            bool isSold,
            Bitmap image,
            string imagePath)
        {
            Id = id;
            this.VIN = VIN;
            Model = model;
            Manufacturer = manufacturer;
            ManufacturedYear = manufacturedYear;
            Price = price;
            DistanceCovered = distanceCovered;
            IsSold = isSold;
            Image = image;
            ImagePath = imagePath;
        }
    }
}
