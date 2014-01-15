using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_BoilerPlate.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            LoadCommand = CommandFromFunction((x) => Name = "Load");
            BootstrapCommand = CommandFromFunction((x) => Name = "Boot");
            MigrateCommand = CommandFromFunction((x) => Name = "Migrate");
            SmoothCommand = CommandFromFunction((x) => Name = "Smooth");
            GalumCommand = CommandFromFunction((x) => Name = "Galum");
        }
        #region Commands
        public ICommand MigrateCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand BootstrapCommand { get; set; }
        public ICommand SmoothCommand { get; set; }
        public ICommand GalumCommand { get; set; }
        #endregion

        #region Properties
        private string name;
        public string Name
        {
            get { return name; }
            set { SetField(ref name, value); }
        }
        #endregion
    }
}
