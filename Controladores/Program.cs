
using EjercicioCalculadora.Servicios;

namespace EjercicioCalculadora.Controladores
{
    /// <summary>
    /// clase principal de la aplicacion
    /// 17102023 - jrt
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            /// se declara un objeto de tipo menu interfaz al que llamamos mi
            /// y a ese objeto le vamos a crear una copia del tipo menu implementacion, es decir se crea una 
            /// instancia menu implementacion para decirle lo que hace. Solo se puede utilizar dentro del main
        
            OperacionesInterfaz oi = new OperacionesImplementacion();

            int opcionSeleccionada;
            bool cerrarMenu = false;
            /// bool sirve para controlar el flujo de datos mediante condiciones
            /// se fuerza siempre que valga false

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                /// mi es una copia de menu interfaz a llamando al metodo que hay dentro de mi, e ira al 
                /// menu implementacion para mostrar el detalle que hay. mostrar menu y seleccion nos devuelve un entero
                /// es decir, la copia de la opcion seleccionada de nuestro usuario
                switch (opcionSeleccionada)
                    ///coge la opcion introducida por el usuario, dependiendo la opcion que seleccione se lleva a cabo determinado
                    ///tipo de case
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                        
                    case 1:
                        oi.sumar();
                        break;
                        /// nos saca del switch
                    case 2:
                        oi.restar();
                        break;
                    case 3:
                        oi.multiplicar();
                        break;
                    case 4:
                        oi.dividir();
                        break;


                }

            }
        }
    }