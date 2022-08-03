using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlataforma
{
    public interface IOS

    {

        public button CreateButton(string text);
        public Label CreateLabel(string label);
        public Icon CreateIcon(string type);
    }
}
