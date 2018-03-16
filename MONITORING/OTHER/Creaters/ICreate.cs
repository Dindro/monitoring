using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace MONITORING
{
    interface ICreate
    {
        Folder CreateFolder(Action action);
        Select CreateSelect(Action action);
        UserControl CreateFolderView();
        UserControl CreateSelectView();
        object CreateFolderViewModel(Component component, Database database);
        object CreateSelectViewModel(Component component, Database database);
    }
}
