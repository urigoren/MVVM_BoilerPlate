using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_BoilerPlate.Models
{
    interface IModel
    {
        MVVM_BoilerPlate.ViewModels.BaseViewModel ViewModel();
    }
}
