using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace MONITORING
{
    class RulesViewModel:PropertyChangedClass
    {
        private ObservableCollection<RulesItemViewModel> rules;
        public ObservableCollection<RulesItemViewModel> Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        public RulesViewModel()
        {
            Rules = new ObservableCollection<RulesItemViewModel>();
        }

        private RulesItemViewModel selectedItem;
        public RulesItemViewModel SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public void DeleteRule()
        {
            if (SelectedItem == null)
                return;

            int index = Rules.IndexOf(SelectedItem);
            int oldRuleCount = Rules.Count;

            Rules.Remove(SelectedItem);

            if (index + 1 == oldRuleCount && Rules.Count != 0)
                SelectedItem = Rules[index - 1];
            else if(index < Rules.Count && Rules.Count!=0)
                SelectedItem = Rules[index];
        }
    }
}
