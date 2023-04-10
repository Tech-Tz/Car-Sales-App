using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.MVC
{
    public class ViewManager : IViewActivator, IViewDeactivator
    {
        private readonly IDictionary<Type, ViewControllerPair> _viewMappings = new Dictionary<Type, ViewControllerPair>();

        private readonly IList<IView> _views = new List<IView>();

        public void RegisterViews<T, U, V>() => _viewMappings.Add(typeof(T), new ViewControllerPair(typeof(U), typeof(V)));

        public void Activate<T, U>(U viewParameter = null)
            where T : IView
            where U : class, IViewParameter 
            => Activate<T, U>(v => v.OpenView(), viewParameter);

        public void ActivateModal<T, U>(U viewParameter = null)
            where T : IView
            where U : class, IViewParameter 
            => Activate<T, U>(v => v.OpenViewModal(), viewParameter);

        private void Activate<T, U>(Action<T> openView = null, U viewParameter = null)
            where T : IView
            where U : class, IViewParameter
        {
            var mappingSuccesful = _viewMappings.TryGetValue(typeof(T), out ViewControllerPair viewControllerPair);
            if (!mappingSuccesful)
                throw new Exception("Mapping not successful.");

            T newView;

            bool viewAlreadyActivated = _views.Any(v => v.GetType() == viewControllerPair.ViewType);

            if (!viewAlreadyActivated)
            {
                newView = (T)Activator.CreateInstance(viewControllerPair.ViewType);
                CreateController(newView, viewParameter, viewControllerPair);
                _views.Add(newView);
                openView?.Invoke(newView);
            }
            else
            {
                var view = _views.First(v => v.GetType() == viewControllerPair.ViewType);
                CreateController(view, viewParameter, viewControllerPair);
            }
        }

        private void CreateController(IView view, IViewParameter viewParam, ViewControllerPair vcPair)
        {
            if (viewParam != null)
                Activator.CreateInstance(vcPair.ControllerType, view, this, this, viewParam);
            else
                Activator.CreateInstance(vcPair.ControllerType, view, this, this);
        }

        public void Deactivate<T, U>(BaseController<T, U> controller) 
            where T : class, IView
            where U : class, IViewParameter
        {
            controller.View.IsDeactivated = true;
            controller.View.CloseView(); // Disposes automatically in case of winforms
            _views.Remove(controller.View);
            controller.Dispose();
        }
    }
}
