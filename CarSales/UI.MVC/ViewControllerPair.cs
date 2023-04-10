using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.MVC
{
    public class ViewControllerPair
    {
        public Type ViewType { get; private set; }
        public Type ControllerType { get; private set; }
        public ViewControllerPair(Type view, Type controller)
        {
            ViewType = view;
            ControllerType = controller;
        }
    }
}
