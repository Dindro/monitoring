using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace MONITORING
{
    class CreaterList : ICreate
    {
        public Folder CreateFolder(Action action)
        {
            return new FolderList(action);
        }

        public UserControl CreateFolderView()
        {
            return new FolderListView();
        }

        public object CreateFolderViewModel(Component component, Database database)
        {
            return new FolderListViewModel(component, database);
        }

        public Select CreateSelect(Action action)
        {
            return new SelectList(action);
        }

        public UserControl CreateSelectView()
        {
            return new SelectListView();
        }

        public object CreateSelectViewModel(Component component, Database database)
        {
            return new SelectListViewModel(component, database);
        }
    }


}
