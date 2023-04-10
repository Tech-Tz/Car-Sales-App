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
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public int Add(CustomerEntity entity)
        {
            return dbContext.Execute((conn, tran) =>
            {
                StringBuilder sbQuery = new StringBuilder();
                sbQuery
                    .AppendLine("insert into Customers ([Name], Email, PhoneNumber)")
                    .AppendLine("select @name, @email, @phoneNumber;")
                    .AppendLine("select cast(scope_identity() as int);");

                var id = conn.QuerySingle<int>(sbQuery.ToString(), new
                {
                    name = entity.Name,
                    email = entity.Email,
                    phoneNumber = entity.PhoneNumber,
                }, tran);

                return id;
            });
        }

        public void Delete(int id)
        {
            dbContext.Execute((conn, tran) =>
            {
                conn.Execute("delete Customers where Id = @id", new { id = id }, tran);
            });
        }

        public IEnumerable<CustomerEntity> GetAll()
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, [Name], Email, PhoneNumber")
                    .AppendLine("from Customers");
                return conn.Query<CustomerEntity>(query.ToString());
            });
        }

        public CustomerEntity GetByEmail(string email)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, [Name], Email, PhoneNumber")
                    .AppendLine("from Customers")
                    .AppendLine("where Email = @email");
                return conn.QuerySingle<CustomerEntity>(query.ToString(), new { email = email });
            });
        }

        public CustomerEntity GetById(int id)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, [Name], Email, PhoneNumber")
                    .AppendLine("from Customers")
                    .AppendLine("where id = @id");
                return conn.QuerySingle<CustomerEntity>(query.ToString(), new { id = id });
            });
        }

        public IEnumerable<CustomerEntity> GetByName(string name)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, [Name], Email, PhoneNumber")
                    .AppendLine("from Customers")
                    .AppendLine("where [Name] = @name");
                return conn.Query<CustomerEntity>(query.ToString(), new { name = name });
            });
        }

        public CustomerEntity GetByPhoneNumber(string phoneNumber)
        {
            return dbContext.Execute(conn =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, [Name], Email, PhoneNumber")
                    .AppendLine("from Customers")
                    .AppendLine("where PhoneNumber = @phoneNumber");
                return conn.QuerySingle<CustomerEntity>(query.ToString(), new { phoneNumber = phoneNumber });
            });
        }

        public void Update(CustomerEntity entity)
        {
            dbContext.Execute((conn, tran) =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("update Customers")
                    .AppendLine("set [Name] = @name")
                    .AppendLine("   ,Email = @email")
                    .AppendLine("   ,PhoneNumber = @phoneNumber")
                    .AppendLine("where Id = @id");
                conn.Execute(query.ToString(), new
                {
                    name = entity.Name,
                    email = entity.Email,
                    phoneNumber = entity.PhoneNumber,
                    id = entity.Id,
                }, tran);
            });
        }
    }
}
