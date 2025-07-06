using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursopromacion.sistemadeinventario
{
    internal class productos
    {
        /*
         Sistema de Inventario
        Objetivo: Clase Producto (nombre, precio, cantidad) y una 
        lista para agregar/eliminar productos.
        Extras: Calcular el valor total del inventario.
        Buscar productos por nombre.
         */
        // <summary>
        /// Clase que representa un producto en el sistema de inventario.
        /// son autoimplemencion de las propiedades de la clase pruductos.
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        /// </summary>
        /// <summary>
        /// esta clase representa un producto con nombre, precio y cantidad.
        /// esto es el constructor de la clase pruductos.
        public productos ( string nombre, double precio, int cantidad)
        { 
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
        }
        /// </summary>
        /// <summary>
        /// esto es para mostrar la informacion del producto.
        ///</summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio}, Cantidad: {Cantidad}");
        }

    }
}

