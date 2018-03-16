using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows;

namespace MONITORING
{
    class TemplateItemViewModel : PropertyChangedClass
    {
        TemplateItem template;
        public TemplateItem Template { get { return template; } }

        public TemplateItemViewModel(TemplateItem template)
        {
            this.template = template;
        }

        public string Title
        {
            get
            {
                if (Code.Length >= 18)
                    return Code.Substring(0, 18) + "...";
                else
                    return Code;
            }
        }

        public string ID
        {
            get { return template.id.ToString(); }
        }


        public string Code
        {
            get { return template.code; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    template.code = value;
                    OnPropertyChanged("Code");
                    OnPropertyChanged("Title");
                }
                else
                {
                    MessageBox.Show("The string can not be empty!");
                }
            }
        }
    }
}
