using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Clases
{
    internal class Celular_Defectuoso : Celular
    {

        public String Fecha_Defecto { get; set; }
        public String Motivo { get; set; }

        public override void MostrarCelular()
        {
            base.MostrarCelular();
            Console.Write("Fecha de Defecto: {0}\nMotivo: {1}\n", Fecha_Defecto, Motivo);
        }

    }
}