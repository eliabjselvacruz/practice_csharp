using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este es una impresión en consola sin salto de línea.
            Console.Write("Impresión en consola sin salto de línea.");
            //Este es un salto de línea.
            Console.Write("\n");
            //Este es una impresión en consola con salto de línea.
            Console.WriteLine("Impresión en consola con salto de línea.");

            //Este es una impresión en consola sin salto de línea y empleando formato de texto.
            Console.WriteLine("51 + 1 = {0}", (51 + 1));

            //Declaracíon de una variable de tipo cadena.
            string nombre;

            //Declaración e inicialización de una variable de tipo cadena.
            string apellido = "Selva";

            //Declaración de una variable y asignación de su valor.
            string correo;
            correo = "eliabjselvacruz51@gmail.com";

            //Impresión en consola de una variable.
            Console.WriteLine(correo);

            //Declaración de diferentes tipos de variables.
            int num = 51;
            double precio= 51.51D;
            char sexo = 'm';
            bool resp = false;
            string texto = "Stronger";

            //Declaración e inicialización de una constante numerica.
            const int valor = 51;

            //Impresión de una constante.
            Console.WriteLine("Constante:" + valor);

            //Declaración e incialización de variables de tipo cadena.
            string nombre1 = "Eliab", nombre2 = "Javier", apellido1 = "Selva", apellido2 = "Cruz", nombreCompleto;

            //Concatenación de cadenas.
            nombreCompleto = nombre1 + " " + nombre2 + " " + apellido1 + " " + apellido2;

            //Impresión de variable de tipo cadena.
            Console.WriteLine(nombreCompleto);

            //Declaración (con formato) e impresión de variable numérica. 
            int n = 1_000_000;
            Console.WriteLine(n);

            //Esta instrucción permite detener la ejecución hasta que se precione una tecla.
            Console.ReadKey();
        }
    }
}
