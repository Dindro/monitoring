using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    //ВкладкаViewModel
    abstract class InsetViewModel : PropertyChangedClass
    {
        protected abstract void LoadSettings();
        protected abstract void UpdateComponent();

        protected Database database;
        protected Component component;

        public InsetViewModel(Component component, Database database)
        {
            this.component = component;
            this.database = database;
            LoadSettings();
        }

        private Command save;
        public Command Save
        {
            get
            {
                return save ??
                  (save = new Command(obj =>
                  {
                      UpdateComponent();
                      database.UpdateComponent(component);
                  }));
            }
        }

        private Command cancel;
        public Command Cancel
        {
            get
            {
                return cancel ??
                  (cancel = new Command(obj =>
                  {
                      LoadSettings();
                  }));
            }
        }
    }
}
