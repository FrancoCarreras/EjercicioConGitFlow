using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("**********REALIZAR UNA OPERACION**********");
                Console.WriteLine("1) Realizar una suma");
                Console.WriteLine("2) Realizar una resta");
                Console.WriteLine("3) Realizar una division");
                Console.WriteLine("4) Realizar una multiplicacion");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta != 1 && respuesta != 2 && respuesta != 3 && respuesta != 4);

            Console.Clear();

            switch (respuesta)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;
            }
        }
    }
}
