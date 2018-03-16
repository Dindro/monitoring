using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class SelectList : Select
    {
        public SelectList(Action action) : base(action)
        {
            Settings = new List<Setting>()
            {
                new Setting(1, 0, 0),
                new Setting(2, 0 ,0),
                new Setting(3, 0, 0),
                new Setting(4, 0, 10)
            };
        }

        protected override string CreateTitle()
        {
            return "Select";
        }
    }
}
