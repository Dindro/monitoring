using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace MONITORING
{
    class FolderTreeViewModel : ComponentTreeViewModel
    {
        private ObservableCollection<SelectTreeViewModel> selects;
        public ObservableCollection<SelectTreeViewModel> Selects { get { return selects; } }

        public override Component Component{ get { return (Folder)component; } }

        public FolderTreeViewModel(Folder folder, Database database) : base(folder, database)
        {
            selects = new ObservableCollection<SelectTreeViewModel>();

            foreach (Select select in folder.Selects)
            {
                selects.Add(new SelectTreeViewModel(select, database));
            }
        }
        
        public void Add(Select select)
        {
            (Component as Folder).Selects.Add(select);
            Selects.Add(new SelectTreeViewModel(select, database));
        } 

        public void Remove(SelectTreeViewModel selectVM)
        {
            Select select = (Select)selectVM.Component;
            Folder folder = (Folder)Component;
            folder.Selects.Remove(select);
            Selects.Remove(selectVM);
        }
    }
}
