using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlataforma
{
    public class Aplication 
    {
        public IOS plataforma;// Relacion de asociacion 

        List<GUiObject> GUI;

        public Aplication(IOS plataforma)/// Constructor
        {
            this.plataforma = plataforma;
            GUI = new List<GUiObject>();
        }
        public void CrearIU()
        {
            Label titulo = plataforma.CreateLabel("Are you sure");
            Label mensaje = plataforma.CreateLabel("One deleted, you will not be able to recover this");
            Icon iconoalerta = plataforma.CreateIcon("Alerta");
            button buttonOk = plataforma.CreateButton("OK");
            button buttonCancelar = plataforma.CreateButton("Cancelar ");

            GUI.Add(titulo);
            GUI.Add(mensaje);
            GUI.Add(iconoalerta);
            GUI.Add(buttonOk);
            GUI.Add(buttonCancelar);
        }
        public void Paint()
        {
            String pantalla="";
            foreach(var objeto in GUI)
            {
                pantalla += objeto.Paint() + "\n";
            }

            Console.WriteLine(pantalla);
        }
    }
}
