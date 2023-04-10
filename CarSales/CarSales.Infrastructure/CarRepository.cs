using CarSales.Core.Entities;
using CarSales.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CarSales.Infrastructure
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public int Add(CarEntity entity)
        {
            return dbContext.Execute((conn, tran) =>
            {
                StringBuilder sbQuery = new StringBuilder();
                sbQuery
                    .AppendLine("insert into Cars (VIN, Manufacturer, ManufacturedYear, Price, Model, ImagePath)")
                    .AppendLine("select @VIN, @Manufacturer, @ManufacturedYear, @Price, @Model, @ImagePath;")
                    .AppendLine("select cast(scope_identity() as int);");

                var id = conn.QuerySingle<int>(sbQuery.ToString(), new
                {
                    VIN = entity.VIN,
                    Manufacturer = entity.Manufacturer,
                    ManufacturedYear = entity.ManufacturedYear,
                    Price = entity.Price,
                    Model = entity.Model,
                    ImagePath = entity.ImagePath
                }, tran);


                if (entity.DistanceCovered.HasValue)
                {
                    sbQuery = new StringBuilder();
                    sbQuery
                        .AppendLine("insert into UsedCars (Id, DistanceCovered)")
                        .AppendLine("select @Id, @DistanceCovered");
                    conn.Execute(sbQuery.ToString(), new
                    {
                        Id = id,
                        DistanceCovered = entity.DistanceCovered.Value,
                    }, tran);
                }

                return id;
            });
        }

        public void Delete(int id)
        {
            dbContext.Execute((conn, tran) => 
            {
                conn.Execute("delete Cars where Id = @id", new { id = id }, tran);
            });
        }

        public IEnumerable<CarEntity> GetAll()
        {
            return dbContext.Execute(conn => 
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id");
                return conn.Query<CarEntity>(query.ToString());
            });
        }

        public IEnumerable<CarEntity> GetByDistanceCovered(decimal distanceCovered)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where UsedCars.DistanceCovered = @distanceCovered");
                return conn.Query<CarEntity>(query.ToString(), new { distanceCovered = distanceCovered });
            });
        }

        public IEnumerable<CarEntity> GetByDistanceCoveredGreaterThan(decimal distanceCovered)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where UsedCars.DistanceCovered > @distanceCovered");
                return conn.Query<CarEntity>(query.ToString(), new { distanceCovered = distanceCovered });
            });
        }

        public IEnumerable<CarEntity> GetByDistanceCoveredLessThan(decimal distanceCovered)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where UsedCars.DistanceCovered < @distanceCovered");
                return conn.Query<CarEntity>(query.ToString(), new { distanceCovered = distanceCovered });
            });
        }

        public CarEntity GetById(int id)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.Id = @id");
                return conn.QuerySingle<CarEntity>(query.ToString(), new { id = id });
            });
        }

        public IEnumerable<CarEntity> GetByManufacturer(string manufacturer)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.Manufacturer = @manufacturer");
                return conn.Query<CarEntity>(query.ToString(), new { manufacturer = manufacturer });
            });
        }

        public IEnumerable<CarEntity> GetByModel(string model)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.Model = @model");
                return conn.Query<CarEntity>(query.ToString(), new { model = model });
            });
        }

        public IEnumerable<CarEntity> GetByPrice(decimal price)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.Price = @price");
                return conn.Query<CarEntity>(query.ToString(), new { price = price });
            });
        }

        public IEnumerable<CarEntity> GetByPriceGreaterThan(decimal price)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.Price > @price");
                return conn.Query<CarEntity>(query.ToString(), new { price = price });
            });
        }

        public IEnumerable<CarEntity> GetByPriceLessThan(decimal price)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.Price < @price");
                return conn.Query<CarEntity>(query.ToString(), new { price = price });
            });
        }

        public IEnumerable<CarEntity> GetByPurchaseDate(DateTime purchaseDate)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("inner join Sales")
                    .AppendLine("on Cars.Id = Sales.CarId")
                    .AppendLine("where Sales.PurchaseDate = @purchaseDate");
                return conn.Query<CarEntity>(query.ToString(), new { purchaseDate = purchaseDate });
            });
        }

        public IEnumerable<CarEntity> GetByPurchaseDateGreaterThan(DateTime purchaseDate)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("inner join Sales")
                    .AppendLine("on Cars.Id = Sales.CarId")
                    .AppendLine("where Sales.PurchaseDate > @purchaseDate");
                return conn.Query<CarEntity>(query.ToString(), new { purchaseDate = purchaseDate });
            });
        }

        public IEnumerable<CarEntity> GetByPurchaseDateLessThan(DateTime purchaseDate)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("inner join Sales")
                    .AppendLine("on Cars.Id = Sales.CarId")
                    .AppendLine("where Sales.PurchaseDate < @purchaseDate");
                return conn.Query<CarEntity>(query.ToString(), new { purchaseDate = purchaseDate });
            });
        }

        public CarEntity GetByVIN(string VIN)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where Cars.VIN = @VIN");
                return conn.QuerySingleOrDefault<CarEntity>(query.ToString(), new { VIN = VIN });
            });
        }

        public IEnumerable<CarEntity> GetSoldCars()
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("left join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id")
                    .AppendLine("where exists (select 1 from Sales where Sales.CarId = Cars.Id)");
                return conn.Query<CarEntity>(query.ToString());
            });
        }

        public IEnumerable<CarEntity> GetUnusedCars()
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath")
                    .AppendLine("from Cars")
                    .AppendLine("where not exists (")
                    .AppendLine("   select 1")
                    .AppendLine("   from UsedCars")
                    .AppendLine("   where UsedCars.Id = Cars.Id")
                    .AppendLine(")");
                    
                return conn.Query<CarEntity>(query.ToString());
            });
        }

        public IEnumerable<CarEntity> GetUsedCars()
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Cars.VIN, Cars.Id, Cars.Manufacturer, Cars.ManufacturedYear, Cars.Price, Cars.Model, Cars.ImagePath, UsedCars.DistanceCovered")
                    .AppendLine("from Cars")
                    .AppendLine("inner join UsedCars")
                    .AppendLine("on Cars.Id = UsedCars.Id");
                return conn.Query<CarEntity>(query.ToString());
            });
        }

        public string SaveCarImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                return null;

            string destinationDirectory = @"..\..\..\..\..\Car images";
            string savedImagePath = Path.Combine(destinationDirectory, Path.GetFileName(imagePath));
            if (!File.Exists(savedImagePath))
                File.Copy(imagePath, savedImagePath);
            return savedImagePath;
        }

        public void Update(CarEntity entity)
        {
            dbContext.Execute((conn, tran) => 
            {
                var query = new StringBuilder();
                query
                    .AppendLine("update Cars")
                    .AppendLine("set Manufacturer = @manufacturer")
                    .AppendLine("   ,ManufacturedYear = @manufacturedYear")
                    .AppendLine("   ,Price = @price")
                    .AppendLine("   ,Model = @model")
                    .AppendLine("   ,ImagePath = @ImagePath")
                    .AppendLine("   ,VIN = @VIN")
                    .AppendLine("where Id = @id");
                conn.Execute(query.ToString(), new 
                {
                    manufacturer = entity.Manufacturer,
                    manufacturedYear = entity.ManufacturedYear,
                    price = entity.Price,
                    model = entity.Model,
                    ImagePath = entity.ImagePath,
                    id = entity.Id,
                    VIN = entity.VIN
                }, tran);
            });
        }
    }
}
