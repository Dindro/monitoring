using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class TemplateItem
    {
        public TemplateItem(int id, string code)
        {
            this.id = id;
            this.code = code;
        }

        public readonly int id;
        public string code;
    }
}
