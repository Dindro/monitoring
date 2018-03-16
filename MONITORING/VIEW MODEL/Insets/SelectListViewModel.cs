using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace MONITORING
{
    class SelectListViewModel : InsetViewModel
    {
        public SelectListViewModel(Component component, Database database) : base(component, database)
        {
            
        }

        protected override void LoadSettings()
        {
            foreach (Setting setting in component.Settings)
            {
                switch (setting.CFG_ID)
                {
                    case 1:
                        Activate = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;
                    case 2:
                        //Database connection
                        break;
                    case 3:
                        SQLUpdateFrequency = Convert.ToInt32(setting.Val);
                        break;
                    case 4:
                        TimeToShowResult = Convert.ToInt32(setting.Val);
                        TimeToShowResultEnabled = ! database.GetAutoRotateParent(component.ID);
                        break;
                    case 5:
                        EnableMarker = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;
                    case 6:
                        ClearResult = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;
                    case 7:
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        var deserializedResult = serializer.Deserialize<ObservableCollection<RulesItemViewModel>>(setting.Val);
                        SQLFieldsRules.Rules = deserializedResult;
                        break;
                    default:
                        break;
                }

                SQLCommand = component.Code;
            }
        }

        protected override void UpdateComponent()
        {
            foreach (Setting setting in component.Settings)
            {
                switch (setting.CFG_ID)
                {
                    case 7:
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        string serializedResult = serializer.Serialize(SQLFieldsRules.Rules);
                        setting.Val = serializedResult;
                        break;

                    default:
                        break;
                }
            }
        }

        private bool activate;
        public bool Activate
        {
            get { return activate; }
            set
            {
                activate = value;
                OnPropertyChanged("Activate");
            }
        }

        private int sqlUpdateFrequency;
        public int SQLUpdateFrequency
        {
            get { return sqlUpdateFrequency; }
            set
            {
                sqlUpdateFrequency = value;
                OnPropertyChanged("SQLUpdateFrequency");
            }
        }

        private int timeToShowResult;
        public int TimeToShowResult
        {
            get { return timeToShowResult; }
            set
            {
                timeToShowResult = value;
                OnPropertyChanged("TimeToShowResult");
            }
        }

        private bool timeToShowResultEnabled;
        public bool TimeToShowResultEnabled
        {
            get { return timeToShowResultEnabled; }
            set
            {
                timeToShowResultEnabled = value;
                OnPropertyChanged("TimeToShowResultEnabled");
            }
        }

        private string sqlCommand;
        public string SQLCommand
        {
            get { return sqlCommand; }
            set
            {
                sqlCommand = value;
                OnPropertyChanged("SQLCommand");
            }
        }


        private Command template;
        public Command Template
        {
            get
            {
                return template ??
                  (template = new Command(obj =>
                  {
                      TemplateView template = new TemplateView();
                      TemplateViewModel templateVM = new TemplateViewModel(database);
                      template.DataContext = templateVM;
                      template.ShowDialog();
                      if (templateVM.chosenItem != null)
                          SQLCommand = templateVM.chosenItem.Code;
                  }));
            }
        }

        private Command saveAsTemplate;
        public Command SaveAsTemplate
        {
            get
            {
                return saveAsTemplate ??
                  (saveAsTemplate = new Command(obj =>
                  {
                      if (!string.IsNullOrEmpty(SQLCommand) && !string.IsNullOrWhiteSpace(SQLCommand))
                          database.SetTemplate(SQLCommand);
                  }));
            }
        }

        private bool enableMarker;
        public bool EnableMarker
        {
            get { return enableMarker; }
            set
            {
                enableMarker = value;
                if (enableMarker == false)
                {
                    ClearResultEnable = false;
                    ClearResult = true;
                }
                else
                    ClearResultEnable = true;
                OnPropertyChanged("EnableMarker");
            }
        }

        private bool clearResultEnable;
        public bool ClearResultEnable
        {
            get { return clearResultEnable; }
            set
            {
                clearResultEnable = value;
                OnPropertyChanged("ClearResultEnable");
            }
        }

        private bool clearResult;
        public bool ClearResult
        {
            get { return clearResult; }
            set
            {
                clearResult = value;
                OnPropertyChanged("ClearResult");
            }
        }

        private RulesViewModel sqlFieldsRules;
        public RulesViewModel SQLFieldsRules
        {
            get
            {
                if (sqlFieldsRules == null)
                    sqlFieldsRules = new RulesViewModel();
                return sqlFieldsRules;
            }
        }
        
        private Command addRule;
        public Command AddRule
        {
            get
            {
                return addRule ??
                  (addRule = new Command(obj =>
                  {
                      SQLFieldsRules.Rules.Add(new RulesItemViewModel()
                      {
                          Name = "Field",
                          CheckType = 1,
                      });
                  }));
            }
        }

        private Command deleteRule;
        public Command DeleteRule
        {
            get
            {
                return deleteRule ??
                  (deleteRule = new Command(obj =>
                  {
                      SQLFieldsRules.DeleteRule();
                  }));
            }
        }

        
    }

}
