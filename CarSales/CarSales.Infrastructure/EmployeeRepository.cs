using CarSales.Core.Entities;
using CarSales.Core.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public int Add(EmployeeEntity entity)
        {
            return dbContext.Execute((conn, tran) =>
            {
                var query = new StringBuilder();
                query
                    .AppendLine("insert into Employees ([Name], Username, [Password])")
                    .AppendLine($"select @Name, @Username, HASHBYTES('MD5', '{entity.PasswordString}');")
                    .AppendLine("select cast(scope_identity() as int);");

                var id = conn.QuerySingle<int>(query.ToString(), new
                {
                    Name = entity.Name,
                    Username = entity.Username,
                }, tran);
                return id;
            });
        }

        public void Delete(int id)
        {
            dbContext.Execute((conn, tran) => 
            {
                conn.Execute("delete Employees where Id = @Id", new { Id = id }, tran);
            });
        }

        public IEnumerable<EmployeeEntity> GetAll()
        {
            return dbContext.Execute((conn) => 
            {
                return conn.Query<EmployeeEntity>("select Id, Name, Username, Password from Employees");
            });
        }

        public EmployeeEntity GetByCredentials(string username, string password)
        {
            return dbContext.Execute((conn) => 
            {
                var query = new StringBuilder();
                query
                    .AppendLine("select Id, [Name], Username, [Password]")
                    .AppendLine("from Employees")
                    .AppendLine("where Username = @username")
                    .AppendLine($"and [Password] = convert(varbinary, hashbytes('MD5', '{password}'))");
                return conn.QuerySingleOrDefault<EmployeeEntity>(query.ToString(), new 
                {
                    username = username
                });
            });
        }

        public EmployeeEntity GetById(int id)
        {
            return dbContext.Execute((conn) => 
            {
                return conn.QuerySingleOrDefault("select Id, [Name], Username, [Password] from Employees where Id = @id", new
                {
                    id = id
                });
            });
        }

        public EmployeeEntity GetByName(string name)
        {
            return dbContext.Execute((conn) =>
            {
                return conn.QuerySingleOrDefault<EmployeeEntity>("select Id, [Name], Username, [Password] from Employees where [Name] = @name", new
                {
                    name = name
                });
            });
        }

        public bool UsernameExists(string username)
        {
            return dbContext.Execute((conn) =>
            {
                return conn.ExecuteScalar<bool>("select 1 from Employees where Username = @username", new
                {
                    username = username
                });
            });
        }

        public void Update(EmployeeEntity entity)
        {
            dbContext.Execute((conn, tran) => 
            {
                var query = new StringBuilder();
                query
                    .AppendLine("update Employees")
                    .AppendLine("set [Name] = @name")
                    .AppendLine("   ,Username = @username")
                    .AppendLine($"   ,[Password] = HASHBYTES('MD5', '{entity.PasswordString}')")
                    .AppendLine("where Id = @id");
                conn.Execute(query.ToString(), new 
                {
                    name = entity.Name,
                    username = entity.Username,
                    id = entity.Id
                }, tran);
            });
        }
    }
}
