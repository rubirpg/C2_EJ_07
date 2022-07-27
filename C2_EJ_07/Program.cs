using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ej_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me dices tu nombre: ");
            string nombre = Console.ReadLine(); //leemos el nombre y lo guardamos en la variable nombre
            Console.WriteLine("Me dices tu ciudad: ");
            string ciudad = Console.ReadLine(); //leemos la ciudad y lo guardamos en la variable ciudad

            //mostramos por pantalla 
            Console.WriteLine();
            Console.WriteLine("Hola {0} bienvenido a {1}.", nombre, ciudad);
        }
    }
}