using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            int suma, resta, producto;
            decimal division;

            Console.WriteLine("Ingrese el primer número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());
            suma = (numero1 + numero2);
            resta = (numero1 - numero2);
            producto = (numero1 * numero2);
            division = ((decimal)numero1 / (decimal)numero2);

            Console.WriteLine("La suma es: " + suma + "\n" + "La resta es: " + resta + "\n" + "El producto es: " + producto + "\n" + "La división es: " +  division);
            Console.Read();
        }
    }
}
