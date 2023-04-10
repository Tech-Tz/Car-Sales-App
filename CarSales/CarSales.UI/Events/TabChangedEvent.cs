using CarSales.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class TabChangedEvent
    {
        public MainViewTab Tab { get; }
        public TabChangedEvent(MainViewTab tab) => Tab = tab;
    }
}
