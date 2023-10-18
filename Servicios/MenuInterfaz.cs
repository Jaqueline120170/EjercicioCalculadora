using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora.Servicios
{
    /// <summary>
    /// metodos relacionados con el funcionamiento del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// muestra las opciones del menu y solicita al usuario la opcion seleccionada
        /// </summary>
        /// <returns> opcion menu seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
