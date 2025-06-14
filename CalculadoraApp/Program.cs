using CalculadoraCore;
using System;

namespace CalculadoraAPP
{
    class Program 
    {
        static void Main() // Método principal que inicia la ejecución del programa
        {
            double valorActual = 0; // Variable para almacenar el valor actual de la calculadora, inicializado en 0


            int opcion; // Variable para almacenar la opción seleccionada por el usuario


            do
            // Bucle para mostrar el menú y realizar operaciones hasta que el usuario decida salir
            {
                Console.Clear(); // Limpiar la consola para una mejor visualización
                Console.WriteLine("----------------------------");
                Console.WriteLine("   Calculadora UPN - C#     "); // Mostrar título de la calculadora
                Console.WriteLine("----------------------------"); // Mostrar título de la calculadora
                Console.WriteLine($"Valor actual: {valorActual}"); // Mostrar valor actual
                Console.WriteLine("----------------------------"); // Separador visual
                Console.WriteLine("|                          |");
                Console.WriteLine("| 1. Sumar                 |"); // Opción para sumar
                Console.WriteLine("|                          |");
                Console.WriteLine("| 2. Restar                |");// Opción para restar
                Console.WriteLine("|                          |");
                Console.WriteLine("| 3. Multiplicar           |"); // Opción para multiplicar
                Console.WriteLine("|                          |");
                Console.WriteLine("| 4. Dividir               |"); // Opción para dividir
                Console.WriteLine("|                          |");
                Console.WriteLine("| 5. Salir                 |"); // Opción para salir de la calculadora
                Console.WriteLine("|                          |"); // Separador visual
                Console.WriteLine("|--------------------------|");
                Console.Write("Seleccione una opción: "); // Solicitar al usuario que seleccione una opción
                

                opcion = int.Parse(Console.ReadLine()); // Leer la opción seleccionada por el usuario y convertirla a un entero



                switch (opcion) // Iniciar un bloque switch para evaluar la opción seleccionada por el usuario
       
                {
                    case 1: // sumar (ref)
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.WriteLine(" |-------------------------------|");
                        Console.WriteLine(" |   Calculadora UPN - C#        |"); // Mostrar título de la calculadora
                        Console.WriteLine(" |-------------------------------|");
                        Console.WriteLine(" |                               |");
                        Console.WriteLine(" | - Estas en la opcion de suma  |");
                        Console.WriteLine(" |                               |");
                        Console.WriteLine($" | - Tu resultado antiguo es : {valorActual} |"); // Mostrar valor actual
                        Console.WriteLine(" |                               |");
                        Console.WriteLine(" |-------------------------------|"); // Mostrar título de la calculadora
                        Console.WriteLine("                                  ");
                        Console.Write("Ingrese un numero para sumar por favor:  "); // Solicitar al usuario que ingrese un número para sumar
                        double sumando = double.Parse(Console.ReadLine()); // Leer el número ingresado por el usuario y convertirlo a un double
                        Operaciones.Sumar(ref valorActual, sumando); // Llamar al método Sumar de la clase Operaciones, pasando el valor actual por referencia y el número a sumar
                        break;

                    case 2: // restar (ref)
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.WriteLine(" |-------------------------------|");
                        Console.WriteLine(" |   Calculadora UPN - C#        |"); // Mostrar título de la calculadora
                        Console.WriteLine(" |-------------------------------|");
                        Console.WriteLine(" |                               |");
                        Console.WriteLine(" | - Estas en la opcion de resta |");
                        Console.WriteLine(" |                               |");
                        Console.WriteLine($" | - Tu resultado antiguo es : {valorActual} |"); // Mostrar valor actual
                        Console.Write("Ingrese un numero para restar por favor : "); // Solicitar al usuario que ingrese un número para restar
                        double restando = double.Parse(Console.ReadLine()); // Leer el número ingresado por el usuario y convertirlo a un double
                        Operaciones.Restar(ref valorActual, restando); // Llamar al método Restar de la clase Operaciones, pasando el valor actual por referencia y el número a restar
                        break;

                    case 3: // multiplicar (out)
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.Write("Ingrese el numero para multiplicar por favor : "); // Solicitar al usuario que ingrese el factor
                        double factor = double.Parse(Console.ReadLine()); // Leer el factor ingresado por el usuario
                        Operaciones.Multiplicar(valorActual, factor, out double nuevoValor); // Llamar al método Multiplicar de la clase Operaciones, pasando el valor actual y el factor
                        valorActual = nuevoValor; // Actualizar el valor actual con el resultado de la multiplicación
                        break;


                    case 4: // dividir (out) - CORREGIDO
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.Write("Ingrese el numero para dividr porfavor : "); // Solicitar al usuario que ingrese el divisor
                        double divisor = double.Parse(Console.ReadLine()); // Leer el divisor ingresado por el usuario

                        // Verificar si el divisor es cero antes de realizar la división

                        if (Operaciones.Dividir(valorActual, divisor, out double cociente)) // Llamar al método Dividir de la clase Operaciones
                        {
                            valorActual = cociente; // Actualizar el valor actual con el resultado de la división
                        }
                        else // Si el divisor es cero, mostrar un mensaje de error
                        {

                            Console.WriteLine("Error amigo que pasa: La division por cero no permitida , no seas curioso porfavor  ."); // Mostrar mensaje de error si el divisor es cero
                        }
                        break;

                    // Salir de la calculadora

                    case 5:
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.WriteLine("Saliendo de la calculadora..."); // Mensaje de salida
                        Console.WriteLine("Gracias por utilizar la calculadora ..."); // Agradecimiento al usuario
                        break;

                    default:
                        Console.Clear(); // Limpiar la consola para una mejor visualización
                        Console.WriteLine("Opción no valida. Por favor, intente de nuevo."); // Mensaje de error si la opción no es válida
                        break;
                        
                }

            } while (opcion != 5); // Continuar el bucle hasta que el usuario seleccione la opción de salir
            // Finalizar el programa
           
        }
    }
}