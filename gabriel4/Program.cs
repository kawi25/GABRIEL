using System;

namespace gabriel4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca su nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("su nombre es: [1] y tiene {0] años de edad", edad, name);
        }
    }
}
