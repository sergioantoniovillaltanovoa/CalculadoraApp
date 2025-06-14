using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCore
{
    
    public static class Operaciones // Clase estática que contiene métodos para realizar operaciones matemáticas básicas
    {

        public static void Sumar(ref double resultado, double numero) // Método para sumar un número al resultado actual
        {

            resultado += numero; // Sumar un número al resultado actual
        }
    
        public static void Restar(ref double resultado, double numero) // Método para restar un número del resultado actual
        {
           
            resultado -= numero; // Restar un número del resultado actual
        }


        public static void Multiplicar(double a, double b, out double resultado) // Método para multiplicar dos números y devolver el resultado
        {
            
            resultado = a * b; // Multiplicar dos números y asignar el resultado a la variable de salida
        }

        
        public static bool Dividir(double dividiendo, double divisor, out double resultado) // Método para dividir dos números y devolver el resultado
        {
            
            if (divisor == 0) // verificar si el divisor es cero

            {
                resultado = 0; // Asignar cero al resultado si el divisor es cero
                return false;  // Retornar false para indicar que la división no se pudo realizar
            }
            else // Si el divisor no es cero
            {
                resultado = dividiendo / divisor; // Realizar la división y asignar el resultado a la variable de salida
                return true; // Retornar true para indicar que la división se realizó correctamente
            }
        }
    }
}