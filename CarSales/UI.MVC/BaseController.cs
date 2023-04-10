using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.MVC
{
    public abstract class BaseController<T, U> : IDisposable 
        where T : class, IView
        where U : class, IViewParameter
    {
        public T View { get; }
        protected IViewActivator ViewActivator { get; }
        protected IViewDeactivator ViewDeactivator { get; }
        protected U ViewParameter { get; }

        protected BaseController(T view, 
            IViewActivator viewActivator, 
            IViewDeactivator viewDeactivator,
            U viewParameter = null) 
        { 
            View = view;
            View.OnViewClosed = ViewClosedHandler;

            ViewActivator = viewActivator;
            ViewDeactivator = viewDeactivator;
            ViewParameter = viewParameter;
        }

        private void ViewClosedHandler()
        {
            if (!View.IsDeactivated)
                ViewDeactivator.Deactivate(this);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) { }
    }
}
