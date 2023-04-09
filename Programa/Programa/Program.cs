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
                    Operaciones cuentas = new Operaciones();
                    Console.WriteLine("**********REALIZAR UNA SUMA**********");
                    int numeroUno = cuentas.PedirNumero();
                    int numeroDos = cuentas.PedirNumero();

                    cuentas.RealizarSuma(numeroUno, numeroDos);
                    break;

                case 2:
                    Operaciones cuentasResta = new Operaciones();
                    Console.WriteLine("**********REALIZAR UNA RESTA**********");
                    int numeroTres = cuentasResta.PedirNumero();
                    int numeroCuatro = cuentasResta.PedirNumero();

                    cuentasResta.RealizarResta(numeroTres, numeroCuatro);
                    break;

                case 3:
                    Operaciones cuentasMultiplicacion = new Operaciones();
                    Console.WriteLine("**********REALIZAR UNA MULTIPLICACION**********");
                    int numeroCinco = cuentasMultiplicacion.PedirNumero();
                    int numeroSeis = cuentasMultiplicacion.PedirNumero();

                    cuentasMultiplicacion.RealizarMultiplicacion(numeroCinco, numeroSeis);
                    break;

                case 4:

                    break;
            }
        }
    }
}
