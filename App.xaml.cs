using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_BoilerPlate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Models.MainLogic model = new Models.MainLogic();
            Views.MainWindow wnd = new Views.MainWindow();
            wnd.DataContext = model.ViewModel();
            wnd.Show();
        }

    }

}
