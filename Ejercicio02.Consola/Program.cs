

using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] patentes = { "AAA 123", "AA 123 AA", "XYZ 456", "A1B 234", "AB 123 CD" };

            foreach (var patente in patentes)
            {
                bool esValida = ValidadorPatente.Validar(patente);
                Console.WriteLine($"La patente \"{patente}\" es válida: {esValida}");
            }
        }
    }
}
