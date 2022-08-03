using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlataforma
{
    public class WinIcon : Icon
    {
        string type;
        public WinIcon(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";
            switch (type)
            {
                case "Alerta":

                    resultado = "== \n" +
                             "== \n" +
                             "===Alerta===\n" +
                             " ==  == \n" +
                             "     =======\n";
                    break;

                case "Peligro":

                    break;



            }
            return resultado;
        }
    }
}
