
using MultiPlataforma;
using System;

namespace Microsoft
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Aplication app = new Aplication(new OsWindows());
            app. CrearIU();
            app.Paint();
        }
    }
}
