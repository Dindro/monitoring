using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class SelectTreeViewModel : ComponentTreeViewModel
    {
        public override Component Component { get { return (Select)component; } }
        
        public SelectTreeViewModel(Select select, Database database) : base(select, database)
        {
            
        }
    }
}
