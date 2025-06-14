using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCore
{
    
    public static class Operaciones
    {
        // usando ref para actualizar el valor
        public static void Sumar(ref double resultado, double numero)
        {
            // Sumar un número al resultado actual
            resultado += numero;
        }
        // Método para restar, usando ref para actualizar el valor
        public static void Restar(ref double resultado, double numero)
        {
            // Restar un número al resultado actual
            resultado -= numero;
        }

        // usando out para devolver el resultado
        public static void Multiplicar(double a, double b, out double resultado)
        {
            // Multiplicar dos números y devolver el resultado
            resultado = a * b;
        }

        // Método para dividir, usando out para devolver el resultado y manejar división por cero
        public static bool Dividir(double dividiendo, double divisor, out double resultado)
        {
            // Verificar si el divisor es cero antes de realizar la división
            if (divisor == 0)
            // Si el divisor es cero, no se puede realizar la división
            {
                resultado = 0;
                return false; // Division por cero no permitida
            }
            else
            {
                resultado = dividiendo / divisor;
                return true; // Division exitosa
            }
        }
    }
}