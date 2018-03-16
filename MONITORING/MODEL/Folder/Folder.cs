using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class Folder : Component
    {
        public Folder(int id, string title, Action action, string code,
            string addl_data, int parent, int child, List<Setting> settings)
            : base(id, title, action, code, addl_data, parent, child, settings)
        {
            Selects = new List<Select>();
        }

        protected Folder(Action action) : base(action, 0)
        {
            Selects = new List<Select>();
        }

        private List<Select> selects;

        public List<Select> Selects
        {
            get { return selects; }
            set { selects = value; }
        }

        protected override string CreateTitle()
        {
            return "Folder";
        }

        public override object Clone()
        {
            return new Folder
                (this.ID, this.Title, this.Action, this.Code,
                this.Addl_data, this.Parent, this.Child, CloneSettings())
            {
                Selects = CloneSelects()
            };
        }

        private List<Select> CloneSelects()
        {
            List<Select> selects = new List<Select>();
            foreach (Select select in this.Selects)
            {
                selects.Add((Select)select.Clone());
            }
            return selects;
        }
    }
}
