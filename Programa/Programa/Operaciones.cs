using System;
using System.Collections.Generic;
using System.Text;

namespace Programa
{
    class Operaciones
    {
        public int PedirNumero()
        {
            int numero;

            Console.Write("Ingrese un numero entero: ");

            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

                Console.Write("Ingrese otro numero porque anteriormente no ingreso un numero entero: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.Write("Ingrese otro numero porque anteriormente ingreso un numero entero demasiado alto: ");
                numero = int.Parse(Console.ReadLine());
            }

            return numero;
        }

        public void RealizarSuma(int a, int b)
        {
            Console.WriteLine("La suma de los numeros ingresados es: " + (a + b));
        }

        public void RealizarResta(int a, int b)
        {
            Console.WriteLine("La resta de los numeros ingresados es: " + (a - b));
        }

        public void RealizarMultiplicacion(int a, int b)
        {
            Console.WriteLine("La multiplicacion de los numeros ingresados es: " + (a * b));
        }

        public void RealizarDivision(int a, int b)
        {
            Console.WriteLine("La division de los numeros ingresados es: " + (a / b));
        }
    }
}
