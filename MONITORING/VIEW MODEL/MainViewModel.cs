using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MONITORING
{
    class MainViewModel : PropertyChangedClass
    {
        private ICreate creater;
        private ComponentTreeViewModel copyTree;


        readonly ObservableCollection<FolderTreeViewModel> folders;
        public ObservableCollection<FolderTreeViewModel> Folders { get { return folders; } }
        private readonly Database database;
        private readonly Action action;

        public MainViewModel(Action action, ICreate creater, string nameDB)
        {
            this.action = action;
            this.creater = creater;
            database = new Database(nameDB);

            this.folders = new ObservableCollection<FolderTreeViewModel>();
            List<Folder> freshFolders = database.GetFolders(action);
            foreach (Folder folder in freshFolders)
            {
                folder.Selects = database.GetSelects(folder);
                folders.Add(new FolderTreeViewModel(folder, database));
            }
        }

        private UserControl selectView;
        public UserControl SelectView
        {
            get { return selectView; }
            set
            {
                selectView = value;
                OnPropertyChanged("SelectView");
            }
        }

        //COMMANDS

        private Command addFolder;
        public Command AddFolder
        {
            get
            {
                return addFolder ??
                  (addFolder = new Command(obj =>
                  {
                      Folder folder = creater.CreateFolder(action);
                      database.SetFolder(folder);
                      Folders.Add(new FolderTreeViewModel(folder, database));
                  }));
            }
        }

        private Command addSelect;
        public Command AddSelect
        {
            get
            {
                return addSelect ??
                  (addSelect = new Command(obj =>
                  {
                      Select select = creater.CreateSelect(action);
                      SetSelect(select);
                  }));
            }
        }


        private Command selectItem;
        public Command SelectItem
        {
            get
            {
                return selectItem ??
                  (selectItem = new Command(obj =>
                  {
                      ComponentTreeViewModel component = GetSelected();
                      if (obj is FolderTreeViewModel)
                      {
                          SelectView = creater.CreateFolderView();
                          SelectView.DataContext = creater.CreateFolderViewModel(component.Component, database);
                      }
                      else if (obj is SelectTreeViewModel)
                      {
                          SelectView = creater.CreateSelectView();
                          SelectView.DataContext = creater.CreateSelectViewModel(component.Component, database);
                      }
                      else
                      {
                          SelectView = null;
                      }
                  }));
            }
        }

        private Command deleteSelect;
        public Command DeleteSelect
        {
            get
            {
                return deleteSelect ??
                  (deleteSelect = new Command(obj =>
                  {
                      foreach (FolderTreeViewModel folder in Folders)
                      {
                          ComponentTreeViewModel selected = GetSelected();
                          if(folder.Selects.Contains(selected as SelectTreeViewModel))
                          {
                              database.DeleteComponent((Select)(selected as SelectTreeViewModel).Component);
                              folder.Remove(selected as SelectTreeViewModel);
                              break;
                          }
                      }
                  }));
            }
        }

        private Command deleteFolder;
        public Command DeleteFolder
        {
            get
            {
                return deleteFolder ??
                  (deleteFolder = new Command(obj => 
                  {
                      ComponentTreeViewModel selected = GetSelected();
                      if (Folders.Contains(selected as FolderTreeViewModel))
                      {
                          database.DeleteFolder((Folder)(selected as FolderTreeViewModel).Component);
                          Folders.Remove(selected as FolderTreeViewModel);
                      }
                  }));
            }
        }

        private Command copy;
        public Command Copy
        {
            get
            {
                return copy ??
                  (copy = new Command(obj =>
                  {
                      ComponentTreeViewModel selected = GetSelected();
                      if(selected!=null)
                        copyTree = selected;
                  }));
            }
        }


        private Command rename;
        public Command Rename
        {
            get
            {
                return rename ??
                  (rename = new Command(obj =>
                  {
                      ComponentTreeViewModel component = GetSelected();
                      if(component!=null)
                        component.SwitchToEditingMode.Execute(new object());
                  }));
            }
        }


        private Command paste;
        public Command Paste
        {
            get
            {
                return paste ??
                  (paste = new Command(obj =>
                  {
                      if (copyTree is FolderTreeViewModel)
                      {
                          Folder folder = (Folder)copyTree.Component.Clone();
                          database.SetСopiedFolder(folder);
                          Folders.Add(new FolderTreeViewModel(folder, database));         
                      }
                      else if (copyTree is SelectTreeViewModel)
                      {
                          Select select = (Select)copyTree.Component.Clone();
                          SetSelect(select);
                      }
                  }));
            }
        }

        //Получить выделенную ветку
        private ComponentTreeViewModel GetSelected()
        {
            foreach (FolderTreeViewModel folder in Folders)
            {
                if (folder.IsSelected)
                    return folder;
                foreach (SelectTreeViewModel select in folder.Selects)
                {
                    if (select.IsSelected)
                        return select;
                }
            }
            return null;
        }

        //Добавляет в базу и в дерево
        private void SetSelect(Select select)
        {
            FolderTreeViewModel folderTreeVM = GetParentFolderTree();
            if (folderTreeVM != null)
            {
                database.SetSelect(folderTreeVM.ID, select);
                folderTreeVM.Add(select);
            }
        }

        private FolderTreeViewModel GetParentFolderTree()
        {
            ComponentTreeViewModel component = GetSelected();
            if (component is FolderTreeViewModel)
            {
                return component as FolderTreeViewModel;
            }
            else if (component is SelectTreeViewModel)
            {
                foreach (FolderTreeViewModel folder in Folders)
                {
                    foreach (SelectTreeViewModel select in folder.Selects)
                    {
                        if (component.ID == select.ID)
                        {
                            return folder;
                        }
                    }
                }
            }
            return null;
        }
    }
}
