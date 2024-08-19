using System.Globalization;

namespace PrimerParcialPOO2024Tema2.Shared
{
    public static class ConsoleExtensions
    {
        // Método para pedir un número entero al usuario
        public static int PedirEntero(string mensaje, int valorMinimo = int.MinValue, int valorMaximo = int.MaxValue)
        {
            int valor;
            bool esValido;
            do
            {
                Console.Write($"{mensaje}: ");
                esValido = int.TryParse(Console.ReadLine(), out valor) && valor >= valorMinimo && valor <= valorMaximo;
                if (!esValido)
                {
                    Console.WriteLine($"Por favor, ingrese un número entero válido entre {valorMinimo} y {valorMaximo}.");
                }
            } while (!esValido);
            return valor;
        }

        // Método para pedir un número decimal al usuario
        public static decimal PedirDecimal(string mensaje, decimal valorMinimo = decimal.MinValue, decimal valorMaximo = decimal.MaxValue)
        {
            decimal valor;
            bool esValido;
            do
            {
                Console.Write($"{mensaje}: ");
                esValido = decimal.TryParse(Console.ReadLine(), out valor) && valor >= valorMinimo && valor <= valorMaximo;
                if (!esValido)
                {
                    Console.WriteLine($"Por favor, ingrese un número decimal válido entre {valorMinimo} y {valorMaximo}.");
                }
            } while (!esValido);
            return valor;
        }

        // Método para pedir un string al usuario
        public static string PedirString(string mensaje, bool obligatorio = true)
        {
            string valor;
            do
            {
                Console.Write($"{mensaje}: ");
                valor = Console.ReadLine();
                if (obligatorio && string.IsNullOrWhiteSpace(valor))
                {
                    Console.WriteLine("Este campo es obligatorio. Por favor, ingrese un valor.");
                }
            } while (obligatorio && string.IsNullOrWhiteSpace(valor));
            return valor;
        }

        // Método para mostrar un menú y devolver la opción elegida
        public static int MostrarMenu(string titulo, string[] opciones)
        {
            int opcion;
            bool esValido;
            do
            {
                Console.WriteLine($"\n--- {titulo} ---");
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }
                opcion = PedirEntero("Seleccione una opción", 1, opciones.Length);
            } while (opcion < 1 || opcion > opciones.Length);
            return opcion;
        }

        // Método para mostrar un mensaje en la consola con un formato específico
        public static void MostrarMensaje(string mensaje, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ResetColor();
        }

        // Método para mostrar un error en la consola
        public static void MostrarError(string mensaje)
        {
            MostrarMensaje(mensaje, ConsoleColor.Red);
        }

    }
}
