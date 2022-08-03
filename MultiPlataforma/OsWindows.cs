using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlataforma
{
    public  class OsWindows : IOS
    {

        // relacion de dependecia 
        public button CreateButton(string text)
        {
            return new WinButton(text);
        }

        public Icon CreateIcon(string type)
        {
            return new WinIcon(type);
        }

        public Label CreateLabel(string label)
        {
            return new winLabel(label);
        }
    }
}

