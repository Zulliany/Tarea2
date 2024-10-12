using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlInventario
{
    internal class Producto
    {
        public string NombreProducto { get; set; }
        public float Costo { get; set; }
        public int Codigo { get; set; }
        public string Bodega { get; set; }
        public Dictionary<Bodega, int> Bodegas { get; set; } = new Dictionary<Bodega, int>();

        public Producto(string nombreProducto, float costo, int codigo)
        {
            NombreProducto = nombreProducto;
            Costo = costo;
            Codigo = codigo;
        }

        public void AgregarABodega(Bodega bodega, int cantidad)
        {
            if (Bodegas.ContainsKey(bodega))
            {
                Bodegas[bodega] += cantidad;
            }
            else
            {
                Bodegas[bodega] = cantidad;
            }
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Producto: {NombreProducto}, Costo: {Costo}";
        }
    }

    public class Bodega
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Bodega(string Nombre, string codigo)
        {
            Nombre = Nombre;
            Codigo = codigo;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Codigo})";
        }
    }

    internal class Productos
    {
        private List<Producto> productos = new List<Producto>();

        public void Ejercicio()
        {
            productos.Add(new Producto("Teclado", 200f, 1678));
            productos.Add(new Producto("Mouse", 500f, 126));
            productos.Add(new Producto("Pantalla", 780f, 478));

            
            Bodega bodega1 = new Bodega("Bodega Central", "Jicaral");

            foreach (var producto in productos)
            {
                Console.WriteLine(producto);
                foreach (var bodega in producto.Bodegas)
                {
                    Console.WriteLine($"  {bodega.Key}: {bodega.Value} unidades");
                }
            }
        }
    }
}

