using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursopromacion
{
    internal class masita
    {
      public void Icm() {
            // mi peso es de 57 kilos
            Console.WriteLine("ingrese su peso real:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su altura real:");
            double altura = double.Parse(Console.ReadLine()); //el singo de + funciona para dos cosas como operador aritmetico
            double icm;
            double cons_icm = 18.5;
            icm = peso / (altura *2);
            //forma 01 (metodo de concatenacion               // y operador de concatenacion 
            Console.WriteLine("mi peso es: " + peso + " kilos");
            //forma 02 (interpolacion de cadenas)
            Console.WriteLine($"peso total es: {peso} kilos");    //hay colocarle la variable dentro de llaves y ponerle el signo de $ al principio
            // forma 03 (metodos con parametros)
            Console.WriteLine("mi peso es: {0} kilos y una altura {1} cm " ,peso, altura);    // aqui hay se comienza el 0 por que es una sola variable y 
                                                                                              // un solo parametro que es el llamado de la variable y 
                                                                                             // se tienen que poner en el orden como llamado el parametro
            if (icm > 18.5)
            {
                Console.WriteLine("su peso es ideal ");
            }
            else
            {
                Console.WriteLine("su peso es bajo ");

            }




        }
    }
}
