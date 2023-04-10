using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.MVC
{
    public interface IViewDeactivator
    {
        void Deactivate<T, U>(BaseController<T, U> controller)
            where T : class, IView
            where U : class, IViewParameter;
    }
}
