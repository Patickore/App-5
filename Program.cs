using System;

namespace App_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            var suma = num1 + num2;
            Console.WriteLine("La suma de los numeros es: {0}", suma);
            var resta = num1 - num2;
            Console.WriteLine("La resta de los numeros es: {1}", resta);
            var multiplicacion = num1 + num2;
            Console.WriteLine("La multiplicacion de los numeros es: {2}", multiplicacion);
            var division = num1 / num2;
            Console.WriteLine("La division de los numeros es: {3}", division);
        }
    }
}
