using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlataforma
{
    public class OsMacintosh : IOS
    {
        // implementacion de iNterfaz
        //Relacion de dependecia
        public button CreateButton(string text)
        {
            return new MacButton(text);
        }

        public Icon CreateIcon(string type)
        {
            return new MacIcon(type);
        }

        public Label CreateLabel(string label)
        {
            return new MacLabel(label);
        }
    }
}
