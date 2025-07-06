using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursopromacion.sistemadeinventario
{
    internal class Inventario
    {   // <summary>
        /// Clase que representa un inventario de productos.
        /// se encarga de manejar una lista de productos, agregar, eliminar y calcular el valor total del inventario.
        // </summary>
        private List<productos> productos = new List<productos>();
        // <summary>
        /// Agrega un producto al inventario.
        //</summary>
        public void AgregarProducto(productos producto)
        {
            productos.Add(producto);
            Console.WriteLine($"Producto {producto.Nombre} agregado al inventario.");
        }

        /// <summary>
        /// esto es para mostrar todo lo del inventario.
        /// </summary>
        public void mostrarProductos()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }
            Console.WriteLine("\n---Inventario---/n");
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }
        /// <summary>
        /// buscar productos por nombre. 
        ///</summary>
        public void buscarProdcutos(string nombre) {
            var productoEncontrado = productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
        /// <summary>
        /// esto es para eliminar el producto del inventario.
        /// </summary>
        public void EliminarProducto(string nombre)
        {
            var productoAElimilar = productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (productoAElimilar != null)
            {
                productos.Remove(productoAElimilar);
                Console.WriteLine($"Producto {nombre} eliminado del inventario.");
            }
            else
            {
                Console.WriteLine($"Producto {nombre} no encontrado en el inventario.");
            }
        }


    }

    }
