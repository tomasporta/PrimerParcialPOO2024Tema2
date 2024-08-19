namespace Ejercicio02.Consola
{
    public class ConsoleExtensions
    {



    
        // Método que sirve para pedir un número entero al usuario
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

        // Método paraque sirve  pedir un número decimal al usuario
        public static float PedirFloat(string mensaje, float valorMinimo = float.MinValue, float valorMaximo = float.MaxValue)
        {
            float valor;
            bool esValido;
            do
            {
                Console.Write($"{mensaje}: ");
                esValido = float.TryParse(Console.ReadLine(), out valor) && valor >= valorMinimo && valor <= valorMaximo;
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
        public static int MostrarMenu(string titulo, params string[] opciones)
        {
            int opcion;
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

        // Método para mostrar un aviso en la consola
        public static void MostrarAviso(string mensaje)
        {
            MostrarMensaje(mensaje, ConsoleColor.Yellow);
        }

        // Método para mostrar una lista en la consola
        public static void MostrarLista<T>(string titulo, List<T> lista)
        {
            Console.WriteLine($"\n--- {titulo} ---");
            if (lista.Count == 0)
            {
                MostrarMensaje("La lista está vacía.", ConsoleColor.DarkYellow);
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {lista[i]}");
                }
            }
        }

        // Método para pedir una confirmación (Sí/No)
        public static bool PedirConfirmacion(string mensaje)
        {
            string respuesta;
            do
            {
                Console.Write($"{mensaje} (S/N): ");
                respuesta = Console.ReadLine().Trim().ToUpper();
            } while (respuesta != "S" && respuesta != "N");
            return respuesta == "S";
        }

        // Método para limpiar la consola
        public static void LimpiarConsola()
        {
            Console.Clear();
        }

        // Método para pausar la consola
        public static void PausarConsola(string mensaje = "Presione cualquier tecla para continuar...")
        {
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }

        // Método para centrar texto en la consola
        public static void MostrarTextoCentrado(string mensaje)
        {
            int anchoConsola = Console.WindowWidth;
            int espacios = (anchoConsola - mensaje.Length) / 2;
            Console.WriteLine($"{new string(' ', espacios)}{mensaje}");
        }

        // Método para pedir una fecha al usuario
        public static DateTime PedirFecha(string mensaje, DateTime? fechaMinima = null, DateTime? fechaMaxima = null)
        {
            DateTime fecha;
            bool esValido;
            do
            {
                Console.Write($"{mensaje} (dd/MM/yyyy): ");
                esValido = DateTime.TryParse(Console.ReadLine(), out fecha) &&
                           (!fechaMinima.HasValue || fecha >= fechaMinima) &&
                           (!fechaMaxima.HasValue || fecha <= fechaMaxima);
                if (!esValido)
                {
                    Console.WriteLine("Por favor, ingrese una fecha válida.");
                }
            } while (!esValido);
            return fecha;
        }
    }


}

