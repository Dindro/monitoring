using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class FolderList : Folder
    {
        public FolderList(Action action) : base(action)
        {
            Settings = new List<Setting>()
            {
                new Setting(1, 0, 0),
                new Setting(2, 0, 2),
                new Setting(3, 0, 0),
                new Setting(4, 0, 1),
                new Setting(5, 0, 1),
                new Setting(6, 0, 1),
                new Setting(7, 0, 1),
                new Setting(8, 0, 0),
                new Setting(9, 0, 0),
            };
        }

        protected override string CreateTitle()
        {
            return "Window";
        }
    }
}
