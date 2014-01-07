using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_BoilerPlate.Models
{
    public class MainLogic:IModel
    {
        public MVVM_BoilerPlate.ViewModels.BaseViewModel ViewModel()
        {
            ViewModels.MainViewModel vm= new ViewModels.MainViewModel();
            vm.Name = "Test";
            return vm;
        }
    }
}
