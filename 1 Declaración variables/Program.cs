/* Prueba #1: Verificar el funcionamiento de la declaración de variables anteponiendo el carácter "@" */

using static System.Console;
using System.Threading;

namespace _1_Declaración_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización de variables
            double resultado_suma = 0.0;

            // llamada al método "suma"
            resultado_suma = suma(2.2, 2.2);

            // Impresión del resultado
            WriteLine("El resultado de sumar 2.2 y 2.2 es: " + resultado_suma.ToString());

            // Esta instrucción detiene la ejecución durante 4000 milisegundos
            Thread.Sleep(4000);
        }

        static double suma(double operando_1, double operando_2)
        {
            // Declaración e inicialización de variables
            double @resultado = 0;

            // Utilización de la variable "resultado" anteponiendo el carácter "@"
            @resultado = operando_1 + operando_2;

            // Utilización de la variable "resultado" sin anteponer el carácter "@"
            return resultado;
        }
    }
}
