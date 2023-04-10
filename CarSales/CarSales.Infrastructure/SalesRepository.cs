using CarSales.Core.Entities;
using CarSales.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CarSales.Infrastructure
{
    public class SalesRepository : BaseRepository, ISalesRepository
    {
        public SalesRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public int Add(SalesEntity entity)
        {
            return dbContext.Execute((conn, tran) =>
            {
                StringBuilder sbQuery = new StringBuilder();
                sbQuery
                    .AppendLine("insert into Sales (CustomerId, CarId, EmployeeId, PurchaseDate)")
                    .AppendLine("select @customerId, @carId, @employeeId, @purchaseDate;")
                    .AppendLine("select cast(scope_identity() as int);");

                var id = conn.QuerySingle<int>(sbQuery.ToString(), new
                {
                    customerId = entity.CustomerId,
                    carId = entity.CarId,
                    employeeId = entity.EmployeeId,
                    purchaseDate = entity.PurchaseDate,
                }, tran);

                return id;
            });
        }

        public void Delete(int id)
        {
            dbContext.Execute((conn, tran) =>
            {
                conn.Execute("delete Sales where Id = @id", new { id = id }, tran);
            });
        }

        public IEnumerable<SalesEntity> GetAll()
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales");
                return conn.Query<SalesEntity>(query.ToString());
            });
        }

        public SalesEntity GetByCar(int carId)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("where CarId = @carId");
                return conn.QuerySingle<SalesEntity>(query.ToString(), new { carId = carId });
            });
        }

        public IEnumerable<SalesEntity> GetByCarModel(string carModel)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("inner join Cars")
                    .AppendLine("on Sales.CarId = Cars.Id")
                    .AppendLine("where Cars.Model = @model");
                return conn.Query<SalesEntity>(query.ToString(), new { model = carModel });
            });
        }

        public IEnumerable<SalesEntity> GetByCustomer(int customerId)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("where CustomerId = @customerId");
                return conn.Query<SalesEntity>(query.ToString(), new { customerId = customerId });
            });
        }

        public IEnumerable<SalesEntity> GetByCustomerName(string customerName)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("inner join Customers")
                    .AppendLine("on Sales.CustomerId = Customers.Id")
                    .AppendLine("where Customers.Name = @name");
                return conn.Query<SalesEntity>(query.ToString(), new { name = customerName });
            });
        }

        public IEnumerable<SalesEntity> GetByEmployeeId(string employeeId)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("where EmployeeId = @employeeId");
                return conn.Query<SalesEntity>(query.ToString(), new { employeeId = employeeId });
            });
        }

        public IEnumerable<SalesEntity> GetByEmployeeName(string employeeName)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("inner join Employees")
                    .AppendLine("on Sales.EmployeeId = Employees.Id")
                    .AppendLine("where Employees.Name = @name");
                return conn.Query<SalesEntity>(query.ToString(), new { name = employeeName });
            });
        }

        public SalesEntity GetById(int id)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("where Id = @id");
                return conn.QuerySingle<SalesEntity>(query.ToString(), new { id = id });
            });
        }

        public IEnumerable<SalesEntity> GetByPurchaseDate(DateTime purchaseDate)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, CustomerId, CarId, EmployeeId, PurchaseDate")
                    .AppendLine("from Sales")
                    .AppendLine("where PurchaseDate = @purchaseDate");
                return conn.Query<SalesEntity>(query.ToString(), new { purchaseDate = purchaseDate });
            });
        }

        public void Update(SalesEntity entity)
        {
            dbContext.Execute((conn, tran) =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("update Sales")
                    .AppendLine("set EmployeeId = @employeeId")
                    .AppendLine("   ,CustomerId = @customerId")
                    .AppendLine("   ,CarId = @carId")
                    .AppendLine("   ,PurchaseDate = @purchaseDate")
                    .AppendLine("where Id = @id");
                conn.Execute(query.ToString(), new
                {
                    employeeId = entity.EmployeeId,
                    customerId = entity.CustomerId,
                    carId = entity.CarId,
                    purchaseDate = entity.PurchaseDate,
                    id = entity.Id,
                }, tran);
            });
        }
    }
}
