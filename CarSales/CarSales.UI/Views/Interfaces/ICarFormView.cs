using CarSales.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Views.Interfaces
{
    public interface ICarFormView : IView
    {
        string FormTitle { get; set; }
        string ManufacturerInput { get; set; }
        string ManufacturedYearInput { get; set; }
        string ModelInput { get; set; }
        string PriceInput { get; set; }
        string DistanceCoveredInput { get; set; }
        string ImagePathInput { get; set; }
        string VINInput { get; set; }
        string FileDialogFilter { get; set; }
        string FileDialogTitle { get; set; }

        Action OnSelectImageClicked { get; set; }
        Action OnImageSelected { get; set; }
        Action OnCanceled { get; set; }
        Action OnSubmitted { get; set; }
        Func<char, bool> OnNumericInputTextChanged{ get; set; }

        void OpenFileDialog();
    }
}
