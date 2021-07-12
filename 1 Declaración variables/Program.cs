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
            // Declaración e inicialización de variables
            double @resultado = 0;

            // Utilización de la variable "resultado": Anteponer el carácter "@" es opcional, ya que el nombre de la variable NO coincide con una palabra reservada del lenguaje
            @resultado = operando1 + operando2;

            // Utilización de la variable "resultado": Anteponer el carácter "@" es opcional, ya que el nombre de la variable NO coincide con una palabra reservada del lenguaje
            return resultado;
        }

        private static int SumaNumerosEnteros(int operando1, int operando2)
        {
            // Declaración e inicialización de variables
            int @int = 0;

            // Utilización de la variable "int": Anteponer el carácter "@" en este caso es obligatorio, ya que el nombre de la variable coincide con una palabra reservada del lenguaje
            @int = operando1 + operando2;

            // Utilización de la variable "int": Anteponer el carácter "@" en este caso es obligatorio, ya que el nombre de la variable coincide con una palabra reservada del lenguaje
            return @int;


        }
    }
}
