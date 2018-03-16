using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class TemplateViewModel : PropertyChangedClass
    {
        private ObservableCollection<TemplateItemViewModel> templates;
        public ObservableCollection<TemplateItemViewModel> Templates { get { return templates; } }
        public TemplateItemViewModel chosenItem;
        Database database;

        public TemplateViewModel(Database database)
        {
            this.database = database;
            List<TemplateItem> freshTemplates = database.GetTemplateItems();
            List<TemplateItemViewModel> freshTemplatesVM = new List<TemplateItemViewModel>();
            foreach (TemplateItem template in freshTemplates)
            {
                freshTemplatesVM.Add(new TemplateItemViewModel(template));
            }
            templates = new ObservableCollection<TemplateItemViewModel>(freshTemplatesVM);
        }

        private TemplateItemViewModel selectedItem;
        public TemplateItemViewModel SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        private Command save;
        public Command Save
        {
            get
            {
                return save ??
                  (save = new Command(obj =>
                  {
                      if(selectedItem !=null)
                        database.UpdateTemplateItem(selectedItem.Template);
                  }));
            }
        }

        private Command delete;
        public Command Delete
        {
            get
            {
                return delete ??
                  (delete = new Command(obj =>
                  {
                      if (selectedItem != null)
                      {
                          database.DeleteTemplateItem(selectedItem.Template);
                          Templates.Remove(selectedItem);
                      }
                  }));
            }
        }

        private Command ok;
        public Command OK
        {
            get
            {
                return ok ??
                  (ok = new Command(obj =>
                  {
                      chosenItem = selectedItem;
                  }));
            }
        }
    }
}
