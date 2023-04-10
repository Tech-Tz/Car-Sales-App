using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core
{
    public interface IUnitOfWork : IDisposable
    {
        public void Execute(Action action);
        public T Execute<T>(Func<T> func);
    }
}
