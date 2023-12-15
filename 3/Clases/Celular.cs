using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Clases
{
    internal class Celular
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String SO { get; set; }
        public double RAM { get; set; }
        public int Almacenamiento { get; set; }

        public virtual void MostrarCelular()
        {
            Console.Write("Marca: {0}\nModelo: {1}\nSistema Operativo: {2}\nRam: {3}\nAlmacenamiento: {4}\n",
                               Marca, Modelo, SO, RAM, Almacenamiento);
        }
    }
}