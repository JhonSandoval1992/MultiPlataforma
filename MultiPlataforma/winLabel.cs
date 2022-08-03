using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlataforma
{
   public  class winLabel : Label
    {
        string label;
        public winLabel(string label)
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "==" + label + "==";

        }
    }
}
