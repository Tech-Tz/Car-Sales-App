using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure
{
    public class BaseRepository
    {
        protected readonly DbContext dbContext;

        public BaseRepository(DbContext dbContext) => this.dbContext = dbContext;
    }
}
