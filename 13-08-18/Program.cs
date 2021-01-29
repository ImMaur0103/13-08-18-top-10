using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13_08_18
{
    class Program
    {
        static void Main(string[] args)
        {
            guardar_nombre lista_nombre = new guardar_nombre();
            Console.WriteLine("hello Word");
            Console.ReadKey();
            Console.Write("Escriba su nombre:");
            string nombre = Console.ReadLine();

            Console.Write("Escriba su apellido:");
            string apellido = Console.ReadLine();
            int puntaje = 1;
            try
            {
                Console.Write("Escriba su puntaje:");
                puntaje = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("escriba un puntaje en numeros");
            }
            Console.ReadKey();
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(puntaje);
            Console.ReadKey();
            lista_nombre.top10();
            lista_nombre.llenar(nombre, apellido,puntaje);
            lista_nombre.print();
            Console.ReadKey();



        }
    }
}
