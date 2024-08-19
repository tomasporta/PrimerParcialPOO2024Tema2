using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03.Entidades
{
    public class Millas
    {
        // Atributo privado
        private float distancia;

        // Constructor con un valor por defecto
        public Millas(float distancia = 100)
        {
            this.distancia = distancia;
        }

        // Método para informar la distancia
        public float ObtenerDistancia()
        {
            return distancia;
        }

        // Sobrecarga implícita entre float y Millas
        public static implicit operator Millas(float valor)
        {
            return new Millas(valor);
        }

        public static implicit operator float(Millas millas)
        {
            return millas.distancia;
        }

        // Sobrecarga explícita entre Millas y Kilometros
        public static explicit operator Kilometros(Millas millas)
        {
            return new Kilometros(millas.distancia * 1.60934f);
        }

        // Sobrecarga de los operadores de igualdad
        public static bool operator ==(Millas millas1, Millas millas2)
        {
            return millas1.distancia == millas2.distancia;
        }

        public static bool operator !=(Millas millas1, Millas millas2)
        {
            return !(millas1 == millas2);
        }

        // Sobrecarga del operador de suma
        public static Millas operator +(Millas millas, Kilometros km)
        {
            return new Millas(millas.distancia + ((Millas)km).distancia);
        }

        // Método para sobrecargar Equals y GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Millas)
            {
                return this == (Millas)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return distancia.GetHashCode();
        }
    }

    class Program
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
