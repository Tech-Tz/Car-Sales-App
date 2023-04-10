using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.MVC
{
    public interface IViewActivator
    {
        void Activate<T, U>(U viewParameter = null) 
            where T : IView 
            where U : class, IViewParameter;

        void ActivateModal<T, U>(U viewParameter = null) 
            where T : IView 
            where U : class, IViewParameter;
    }
}
