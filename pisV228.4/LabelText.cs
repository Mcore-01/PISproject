using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    class LabelAtt : Attribute
    {
        public string LabelText { get; set; }
        public LabelAtt(string labelText)
        {
            LabelText = labelText;
        }
    }
}
