using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace MONITORING
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow view = new MainWindow();
            //ListViewModel vm = new ListViewModel(Action.List, "List.cfg");
            MainViewModel vm = new MainViewModel(Action.List, new CreaterList() ,"List.cfg");
            view.List.DataContext = vm;
            view.Show();
        }
    }
}
