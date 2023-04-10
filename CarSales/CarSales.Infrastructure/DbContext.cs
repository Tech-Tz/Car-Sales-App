using CarSales.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure
{
    /// <summary>
    /// TODO: Need to refactor.
    /// </summary>
    public class DbContext : IUnitOfWork
    {
        private readonly IDbConnection connection;
        private IDbTransaction transaction;
        private bool IsInTransactionWork;

        public DbContext(IDbConnection connection) => this.connection = connection;

        public void Execute(Action action)
        {
            Execute(() => { action.Invoke(); return true; });
        }

        public T Execute<T>(Func<T> func)
        {
            if (IsInTransactionWork)
                return func.Invoke();
            else
            {
                try
                {
                    IsInTransactionWork = true;

                    var connectionInitiallyOpened = connection.State == ConnectionState.Open;

                    if (!connectionInitiallyOpened)
                        connection.Open();

                    transaction = connection.BeginTransaction();

                    T result = func.Invoke();

                    transaction.Commit();
                    transaction.Dispose();

                    if (!connectionInitiallyOpened)
                        connection.Close();

                    return result;
                }
                catch (Exception)
                {
                    transaction?.Rollback();
                    transaction?.Dispose();
                    throw;
                }
                finally
                {
                    IsInTransactionWork = false;
                }
            }
        }

        public void Execute(Action<IDbConnection> action)
        {
            Execute((connection) => { action.Invoke(connection); return true; });
        }

        public T Execute<T>(Func<IDbConnection, T> func)
        {
            var connectionInitiallyOpened = connection.State == ConnectionState.Open;

            if (!connectionInitiallyOpened)
                connection.Open();

            T result = func.Invoke(connection);

            if (!connectionInitiallyOpened)
                connection.Close();

            return result;
        }

        public T Execute<T>(Func<IDbConnection, IDbTransaction, T> func)
        {
            if (IsInTransactionWork)
                return func.Invoke(connection, transaction);
            else
            {
                try
                {
                    IsInTransactionWork = true;

                    var connectionInitiallyOpened = connection.State == ConnectionState.Open;

                    if (!connectionInitiallyOpened)
                        connection.Open();

                    transaction = connection.BeginTransaction();

                    T result = func.Invoke(connection, transaction);

                    transaction.Commit();
                    transaction.Dispose();

                    if (!connectionInitiallyOpened)
                        connection.Close();

                    return result;
                }
                catch (Exception)
                {
                    transaction?.Rollback();
                    transaction?.Dispose();
                    throw;
                }
                finally
                {
                    IsInTransactionWork = false;
                }
            }
        }

        public void Execute(Action<IDbConnection, IDbTransaction> action)
        {
            Execute((connection, transaction) => { action.Invoke(connection, transaction); return true; });
        }

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                transaction?.Dispose();
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
