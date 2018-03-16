using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace MONITORING
{
    class SettingsViewModel : PropertyChangedClass
    {
        private ObservableCollection<SelectTreeViewModel> settings;
        public ObservableCollection<SelectTreeViewModel> Settings { get { return settings; } }
        Database database;

        public SettingsViewModel(Database database)
        {
            this.database = database;
        } 
    }
}
