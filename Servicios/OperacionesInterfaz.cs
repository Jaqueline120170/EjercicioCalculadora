using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora.Servicios
{
    /// <summary>
    /// interfaz que declara los metodos operativos de la calculadora
    /// </summary>
    internal interface OperacionesInterfaz
    {
        /// <summary>
        /// solicita al usuario dos operandos y los suma
        /// </summary>
        public void sumar();
        /// <summary>
        /// solicita al usuario dos operandos y los suma 
        /// </summary>
        public void restar();
        /// <summary>
        /// solicita al usuario los dos operandos y los resta
        /// </summary>
        public void multiplicar();
        /// <summary>
        /// solicita al usuario los dos operandos y los multiplica
        /// </summary>

        public void dividir (); 
        /// solicita al usuario los dos operandos y los divide

    }
}
