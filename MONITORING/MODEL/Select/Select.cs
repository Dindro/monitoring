using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class Select : Component, ICloneable
    {
        public Select(int id, string title, Action action, string code,
             string addl_data, int parent, int child, List<Setting> settings)
            : base(id, title, action, code, addl_data, parent, child, settings)
        {

        }

        protected Select(Action action):base(action)
        {

        }

        public override object Clone()
        {
            return new Select(this.ID, this.Title, this.Action, this.Code,
                this.Addl_data, this.Parent, this.Child, CloneSettings());
        }

        protected override string CreateTitle()
        {
            return "Select";
        }
    }
}
