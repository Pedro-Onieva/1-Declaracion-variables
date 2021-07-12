/* Prueba #1: Verificar el funcionamiento de la declaración de variables anteponiendo el carácter "@" */

using static System.Console;

namespace _1_Declaración_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Impresión de resultados
            WriteLine("El resultado de sumar 2.2 y 2.2 es: " + SumaNumerosDecimales(2.2, 2.2).ToString());
            WriteLine("El resultado de sumar 2 y 2 es: " + SumaNumerosEnteros(2, 2).ToString());

            // Esta instrucción detiene la ejecución del programa hasta que el usuario presione cualquier tecla
            ReadKey();
        }

        private static double SumaNumerosDecimales(double operando1, double operando2)
        {
            // Anteponer el carácter "@" es opcional (el nombre de la variable "resultado" NO coincide con ninguna palabra reservada del lenguaje)
            double @resultado = 0;

            @resultado = operando1 + operando2;

            return resultado;
        }

        private static int SumaNumerosEnteros(int operando1, int operando2)
        {
            // Anteponer el carácter "@" es obligatorio (el nombre de la variable "int" coincide con ninguna palabra reservada del lenguaje)
            int @int = 0;

            @int = operando1 + operando2;

            return @int;
        }
    }
}
