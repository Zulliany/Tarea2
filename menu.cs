using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    public class menu 
    {
        public void principio()
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = int.Parse(Console.ReadLine());
                EjecutarOpcion(opcion);
            } while (opcion != 0); 
        }

        private void MostrarMenu()
        {
            Console.WriteLine("1. Ingresar Artículo");
            Console.WriteLine("2. Modificar Artículo");
            Console.WriteLine("3. Consultar Artículos");
            Console.WriteLine("4. Buscar Artículo por Código");
            Console.WriteLine("5. Buscar Artículo por Nombre");
            Console.WriteLine("6. Buscar Artículo en Bodega");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private void EjecutarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    IngresarArticulo();
                    break;
                case 2:
                    ModificarArticulo();
                    break;
                case 3:
                    ConsultarArticulos();
                    break;
                case 4:
                    BuscarArticuloPorCodigo();
                    break;
                case 5:
                    BuscarArticuloPorNombre();
                    break;
                case 6:
                    BuscarArticuloenBodega();
                    break;
                case 0:
                    Console.WriteLine("Salir.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }

        private void IngresarArticulo()
        {
            
        }

        private void ModificarArticulo()
        {
            
        }

        private void ConsultarArticulos()
        {
            
        }

        private void BuscarArticuloPorCodigo()
        {
            
        }

        private void BuscarArticuloPorNombre()
        {
            
        }

        private void BuscarArticuloenBodega()
        {
            
        }
    }
}

