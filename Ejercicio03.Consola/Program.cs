
using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilometros km = new Kilometros(100);
            Millas millas = new Millas(62.1371f);

            // Prueba de suma entre Kilometros y Millas
            Kilometros resultadoKm = km + millas;
            Millas resultadoMillas = millas + km;

            // Imprimir los resultados
            Console.WriteLine($"Resultado en Kilómetros: {resultadoKm.ObtenerDistancia()} km");
            Console.WriteLine($"Resultado en Millas: {resultadoMillas.ObtenerDistancia()} millas");

            // Prueba de igualdad
            Console.WriteLine($"¿Las distancias son iguales?: {km == (Kilometros)millas}");
            Console.WriteLine($"¿Las distancias son iguales?: {millas == (Millas)km}");
        }



    }
    }

