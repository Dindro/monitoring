using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    abstract class Component
    {
        protected abstract string CreateTitle();
        public abstract object Clone();

        public Component(int id, string title, Action action, string code,
            string addl_data, int parent, int child, List<Setting> settings)
        {
            ID = id;
            Title = title;
            Action = action;
            Code = code;
            Addl_data = addl_data;
            Parent = parent;
            Child = child;

            Settings = settings;
        }

        protected Component(Action action, int child):this(action)
        {
            Child = child;
        }

        protected Component(Action action)
        {
            Action = action;
            Title = CreateTitle();
        }

        public List<Setting> Settings { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public Action Action { get; private set; }
        public string Code { get; set; }
        public string Addl_data { get; set; }
        public int Parent { get;  set; }
        public int Child { get; set; }

        protected List<Setting> CloneSettings()
        {
            List<Setting> settings = new List<Setting>();
            foreach (Setting setting in this.Settings)
            {
                settings.Add((Setting)setting.Clone());
            }
            return settings;
        }
    }
}
