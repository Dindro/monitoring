using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MONITORING
{
    abstract class ComponentTreeViewModel : PropertyChangedClass
    {
        protected Database database;
        protected Component component;
        public abstract Component Component { get; }


        protected ComponentTreeViewModel(Component component, Database database)
        {
            this.component = component;
            this.database = database;
        }

        public string Title
        {
            get { return component.Title; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                {
                    if(component.Title != value) //Если прежнее название изменилось
                    {
                        component.Title = value;
                        database.UpdateTitle(component);
                    }      
                }
                OnPropertyChanged("Title");
                IsEditingName = false;
            }
        }
        public int ID { get { return component.ID; } }


        private bool isSelected;
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        private bool isEditingName;
        public bool IsEditingName
        {
            get { return isEditingName; }
            set
            {
                isEditingName = value;
                OnPropertyChanged("IsEditingName");
            }
        }

        private Command switchToEditingMode;
        public Command SwitchToEditingMode
        {
            get
            {
                return switchToEditingMode ??
                  (switchToEditingMode = new Command(obj =>
                  {
                      IsEditingName = !IsEditingName;
                  }));
            }
        }
    }
}
