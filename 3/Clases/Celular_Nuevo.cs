using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Clases
{
    internal class Celular_Nuevo : Celular
    {

        public String Fecha_Ingreso { get; set; }
        public double Precio { get; set; }

        public override void MostrarCelular()
        {
            base.MostrarCelular();
            Console.Write("Fecha de Ingreso: {0}\nPrecio: {1}\n", Fecha_Ingreso, Precio);
        }

        

    }
}