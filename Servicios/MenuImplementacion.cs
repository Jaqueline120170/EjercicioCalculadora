using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// clase que implementa la interfaz
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion()
            /// es publico , se puede llamar desde cualquier metodo, es de tipo entero , debe devolver un entero
        {
            int opcion;
            Console.WriteLine(". cerrar aplicacion");
            Console.WriteLine("1. sumar");
            Console.WriteLine("2. restar");
            Console.WriteLine("3. multiplicar");
            Console.WriteLine("4. dividir");
            Console.WriteLine("seleccione opcion");

            opcion = Console.ReadKey(true).KeyChair - '0';
            /// no me muestra la opcion que ha marcado el ususario, es la orden que recoge de la consola un solo caracter 
            /// marco que lo que va a entrar es del 0 al 9
            return opcion;
            // devuelve el valor de la variable, hace una copia del valor que contenga opcion y una copia de la opcion es lo que va a devolver
        }
    }
}
