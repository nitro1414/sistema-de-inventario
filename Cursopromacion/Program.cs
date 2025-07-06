using Cursopromacion.sistemadeinventario;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cursopromacion
{
    //bloque de codigo
    internal class Program
    {
        int numero1 = 10;
       
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Ingrese un número del 1 al 5 para realizar una acción o 0 para salir:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. mostrar producto");
                Console.WriteLine("3. Buscar producto por nombre");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                string opcion = Console.ReadLine();



                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("agregar producto: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingrese precio");
                        double precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese cantidad");
                        int cantidad = int.Parse(Console.ReadLine());
                        productos nuevoproducto = new productos(nombre, precio, cantidad);
                        inventario.AgregarProducto(nuevoproducto);
                        break;
                    case "2":
                        inventario.mostrarProductos();
                        break;
                    case "3":
                        Console.WriteLine("buscar producto:");
                        string buscarNombre = Console.ReadLine();
                        inventario.buscarProdcutos(buscarNombre);
                        break;
                    case "4":
                        Console.WriteLine("nombre del producto A eliminar:");
                        string nombreEliminar = Console.ReadLine();
                        inventario.EliminarProducto(nombreEliminar);
                        break;
                        case "5":
                            salir=true;
                        break;
                        
                        default:
                            Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                            break;
                    }
                
            }










            /*Random random = new Random();
             random.Next(0,50); // Genera un número aleatorio entre 1 y 100
             Console.WriteLine(random.Next(0,50)); // Imprime el número aleatorio generado*/

        }

        public void prueba()
        {
            int suma = 10 + numero1;
            Console.WriteLine(suma);
        }
       
    }
}



