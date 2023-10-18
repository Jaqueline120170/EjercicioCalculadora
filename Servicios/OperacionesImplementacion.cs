using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/// cosas que nuestra clase puiede llegar  anecesitar

namespace EjercicioCalculadora.Servicios
{
    /// <summary>
    /// nos indica a que proyecto pertenecemos
    /// </summary>
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        private double pedirOperando()
        {
         double operando;
        Console.Writeline("Indique operando");
            operado = double.Parse(Console.ReadLine());
       return operando;
    

        /// <summary>
        ///  se añade un metodo cuyo modificador sera private, lo que nos indic que el metodo qque hare solo puede ser llamado por
        ///  elementos de esta clase, ademas como esta en private no necesito ponerlo en la interfaz, porqe necesito que se llame solo desde dentro
        ///  le pide al usuario los operandos que se requieren par ahacer las operaciones
        /// </summary>
        public void dividir()
        {
            double operandoUno;
            double operandoDos;
            /// les dare el valor que el usuario me dé por pantalla
            Console.WriteLine("Indique un operando");
            /// mensaje que vera el usuario para que indique un operando
            operandoUno = double.Parse(Console.ReadLine());
            /// tendre que convertirlo , coje el tipo double y va a hace runa conversion del console readline al tipo double porque console .readline toma o coge lo que estoy metiendo, coge el texto que estoy metiendo
            /// lo va a coger y lo va a leer, 
            Console.WriteLine("Indique un operando");
            operandoDos = double.Parse(Console.ReadLine());

        }

        public void multiplicar()
        {
            double operandoUno = pedirOperando();
                double operandoDos = pedirOperando();
            double resultado = operandoUno / operandoDos;
                Console.WriteLine(resultado);


        }

        public void restar()
        {
            
        }

        public void sumar()
        {
            
        }
    }
}
