using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursopromacion
{
    /*Realiza una aplicación que le pida al usuario por consola un número del 1 
            al 12. En un condicional switch, deberás evaluar cada uno de los casos y 
            según el caso correcto, mostrar por consola el mes que corresponda a ese 
            número. Por ejemplo, si el usuario introduce un 5, entonces el mensaje que 
            debe aparecer por consola es “Mayo”. Colocar también un mensaje en caso 
            de que el usuario introduzca un número que no se encuentre entre el 1 y 
            12. */
    internal class Class2
    {
        public void  MetodoSwitch()
        {
            Console.WriteLine("Ingrese un numero del 1 al 12: ");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("enero");
                    break;
                case 2:
                    Console.WriteLine("febrero");
                    break;
                case 3:
                    Console.WriteLine("marzo");
                    break;
                case 4:
                    Console.WriteLine("abril");
                    break;
                case 5:
                    Console.WriteLine("mayo");
                    break;
                    case 6:
                        Console.WriteLine("junio");
                    break;
                    case 7: 
                        Console.WriteLine("julio");
                    break;
                    case 8:
                        Console.WriteLine("agosto");
                    break;
                    case 9:
                        Console.WriteLine("septiembre");
                    break;
                    case 10:
                        Console.WriteLine("octubre");
                    break;
                    case 11:
                        Console.WriteLine("noviembre");
                    break;
                    case 12:
                        Console.WriteLine("diciembre");
                    break;
                default:
                    Console.WriteLine("Numero no valido, por favor ingrese un numero del 1 al 12.");
                    break;
            }
        }
    }
}
