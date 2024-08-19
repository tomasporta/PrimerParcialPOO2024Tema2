using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03.Entidades
{
    public  class Kilometros
    {
        // Atributo privado
        private float distancia;

        // Constructor con un valor por defecto
        public Kilometros(float distancia = 100)
        {
            this.distancia = distancia;
        }

        // Método para informar la distancia
        public float ObtenerDistancia()
        {
            return distancia;
        }

        // Sobrecarga implícita entre float y Kilometros
        public static implicit operator Kilometros(float valor)
        {
            return new Kilometros(valor);
        }

        public static implicit operator float(Kilometros km)
        {
            return km.distancia;
        }

        // Sobrecarga explícita entre Kilometros y Millas
        public static explicit operator Millas(Kilometros km)
        {
            return new Millas(km.distancia * 0.621371f);
        }

        // Sobrecarga de los operadores de igualdad
        public static bool operator ==(Kilometros km1, Kilometros km2)
        {
            return km1.distancia == km2.distancia;
        }

        public static bool operator !=(Kilometros km1, Kilometros km2)
        {
            return !(km1 == km2);
        }

        // Sobrecarga del operador de suma
        public static Kilometros operator +(Kilometros km, Millas millas)
        {
            return new Kilometros(km.distancia + ((Kilometros)millas).distancia);
        }

        // Método para sobrecargar Equals y GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Kilometros)
            {
                return this == (Kilometros)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return distancia.GetHashCode();
        }
    }
}
