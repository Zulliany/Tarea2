using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlInventario
{
    public class Arreglos
    {
        private List<Producto> productos = new List<Producto>();

        public void IngresarArticulo()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el costo del producto: ");
            float costo = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el código del producto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el producto a la bodega: ");  
            string bodega = Console.ReadLine();
        }

        public void ModificarArticulo()
        {
            Console.Write("Ingrese el código del producto a modificar: ");
            int codigo = int.Parse(Console.ReadLine());

            Producto producto = productos.Find(p => p.Codigo == codigo);
            if (producto != null)
            {
                Console.Write("Ingrese el nuevo nombre del producto: ");
                producto.NombreProducto = Console.ReadLine();
                Console.Write("Ingrese el nuevo costo del producto: ");
                producto.Costo = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el nuevo producto a la bodega : ");  
                producto.Bodega = Console.ReadLine();

                Console.WriteLine("Producto modificado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void ConsultarArticulos()
        {
            Console.WriteLine("Lista de productos:");
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos en la lista.");
                return;
            }

            foreach (var producto in productos)
            {
                Console.WriteLine(producto);
            }
        }

        public void BuscarArticuloPorCodigo()
        {
            Console.Write("Ingrese el código del producto a buscar: ");
            int codigo = int.Parse(Console.ReadLine());

            Producto producto = productos.Find(p => p.Codigo == codigo);
            if (producto != null)
            {
                Console.WriteLine(producto);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void BuscarArticuloPorNombre()
        {
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string nombre = Console.ReadLine();

            Producto producto = productos.Find(p => p.Bodega.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (producto != null)
            {
                Console.WriteLine(producto);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void BuscarArticuloenBodega()
        {
            Console.Write("Ingrese la bodega del producto a buscar: ");
            string bodega = Console.ReadLine();

            var productosBodega = productos.FindAll(p => p.Bodega.Equals(bodega, StringComparison.OrdinalIgnoreCase));
            if (productosBodega.Count > 0)
            {
                Console.WriteLine($"Productos en la bodega {bodega}:");
                foreach (var producto in productosBodega)
                {
                    Console.WriteLine(producto);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron productos en la bodega especificada.");
            }
        }
    }
}


