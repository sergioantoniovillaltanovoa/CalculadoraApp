using CalculadoraCore;
using System;

namespace CalculadoraAPP
{
    class Program
    {
        static void Main()
        {
            double valorActual = 0;
            int opcion;

            do
            {
                Console.WriteLine("----Calculadora UPN-----");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Valor actual: {valorActual}"); // Mostrar valor actual
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // sumar (ref)
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.Write("Ingrese un numero para sumar: ");
                        double sumando = double.Parse(Console.ReadLine());
                        Operaciones.Sumar(ref valorActual, sumando);
                        break;

                    case 2: // restar (ref)
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.Write("Ingrese un numero para restar: ");
                        double restando = double.Parse(Console.ReadLine());
                        Operaciones.Restar(ref valorActual, restando);
                        break;

                    case 3: // multiplicar (out)
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.Write("Ingrese el factor: ");
                        double factor = double.Parse(Console.ReadLine());
                        Operaciones.Multiplicar(valorActual, factor, out double nuevoValor);
                        valorActual = nuevoValor;
                        break;

                    case 4: // dividir (out) - CORREGIDO
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.Write("Ingrese el divisor: ");
                        double divisor = double.Parse(Console.ReadLine());

                        if (Operaciones.Dividir(valorActual, divisor, out double cociente))
                        {
                            valorActual = cociente;
                        }
                        else
                        {

                            Console.WriteLine("Error: Division por cero no permitida.");
                        }
                        break;

                    case 5:
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.WriteLine("Saliendo de la calculadora...");
                        Console.WriteLine("Gracias por utilizar la calculadora ...");
                        break;

                    default:
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.WriteLine("Opción no valida. Por favor, intente de nuevo.");
                        break;
                        
                }

            } while (opcion != 5);
        }
    }
}