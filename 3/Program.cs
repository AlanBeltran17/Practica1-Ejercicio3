using _3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4.
            //Añadir 10 celulares.
            List<Celular> celulares = new List<Celular>();

            celulares.Add(new Celular_Nuevo()
            {

                Marca = "Samsung",
                Modelo = "S23",
                SO = "Android",
                RAM = 12,
                Almacenamiento = 512,
                Fecha_Ingreso = "2023-10-04",
                Precio = 776.00

            });
            celulares.Add(new Celular_Nuevo()
            {

                Marca = "Apple",
                Modelo = "iPhone 14",
                SO = "iOS",
                RAM = 6,
                Almacenamiento = 128,
                Fecha_Ingreso = "2023-10-09",
                Precio = 799.99

            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Xiaomi",
                Modelo = "Mi 11",
                SO = "Android",
                RAM = 8,
                Almacenamiento = 128,
                Fecha_Ingreso = "2023-10-12",
                Precio = 599.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxy S22",
                SO = "Android",
                RAM = 12,
                Almacenamiento = 256,
                Fecha_Ingreso = "2023-10-14",
                Precio = 899.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Huawei",
                Modelo = "P50 Pro",
                SO = "Android",
                RAM = 8,
                Almacenamiento = 256,
                Fecha_Ingreso = "2023-10-15",
                Precio = 749.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 15",
                SO = "iOS",
                RAM = 6,
                Almacenamiento = 64,
                Fecha_Ingreso = "2023-10-18",
                Precio = 799.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Google",
                Modelo = "Pixel 7",
                SO = "Android",
                RAM = 8,
                Almacenamiento = 128,
                Fecha_Ingreso = "2023-10-20",
                Precio = 699.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "OnePlus",
                Modelo = "9T",
                SO = "Android",
                RAM = 8,
                Almacenamiento = 256,
                Fecha_Ingreso = "2023-10-23",
                Precio = 649.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Sony",
                Modelo = "Xperia XZ5",
                SO = "Android",
                RAM = 8,
                Almacenamiento = 128,
                Fecha_Ingreso = "2023-10-25",
                Precio = 599.99
            });

            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Nokia",
                Modelo = "9.3",
                SO = "Android",
                RAM = 6,
                Almacenamiento = 64,
                Fecha_Ingreso = "2023-10-28",
                Precio = 499.99
            });

            //MOSTRANDO LOS CELULARES NUEVOS
            int i = 1;
            foreach (var cel in celulares)
            {
                Console.WriteLine($"- - - CELULAR {i} - - -");
                cel.MostrarCelular();
                i++;
                Console.WriteLine();
            }
            i = 0;
            //Funcion Prom_Celular con expresion Lambda
            double suma = 0;
            var promedioPrecio = (double sum, double precios) => sum + precios;
            foreach (var cel in celulares.OfType<Celular_Nuevo>())
            {
                suma = promedioPrecio(suma, cel.Precio);
                i++;
            }
            double promedio = suma / i;
            Console.WriteLine("Promedio de precios de los celulares nuevos: " + promedio);

            Console.ReadKey();
        }
    }
}