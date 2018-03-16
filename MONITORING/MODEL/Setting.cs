using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class Setting : ICloneable
    {
        public Setting(int CFG_ID, string Type, string Val)
        {
            this.CFG_ID = CFG_ID;
            this.Type = Type;
            this.Val = Val;
        }

        public Setting(int CFG_ID, int Type, int Val):this(CFG_ID, Type.ToString(), Val.ToString())
        {

        }


        public int CFG_ID { get; set; }
        public string Type { get; set; }
        public string Val { get; set; }

        public object Clone()
        {
            return new Setting(this.CFG_ID, this.Type, this.Val);
        }
    }
}
