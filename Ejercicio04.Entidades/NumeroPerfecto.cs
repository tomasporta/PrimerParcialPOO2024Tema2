namespace Ejercicio04.Entidades
{
    public class NumeroPerfecto
    {
        // Método que se usa  para validar si el número es perfecto
        //public bool EsValido()
        //{
        //    int suma = 0;
        //    for (int i = 1; i < Valor; i++)
        //    {
        //        if (Valor % i == 0)
        //        {
        //            suma += i;
        //        }
        //    }
        //    return suma == Valor;
        //}
        public int Valor { get; set; }

        // Constructor
        public NumeroPerfecto(int valor)
        {
            Valor = valor;
        }

        // Método para validar si el número es perfecto
        public static bool EsPerfecto(int numero)
        {
            if (numero <= 1) return false;

            int sumaDivisores = Enumerable.Range(1, numero / 2)
                                           .Where(x => numero % x == 0)
                                           .Sum();

            return sumaDivisores == numero;
        }

        // Sobrescribir Equals y GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is NumeroPerfecto)
            {
                return this.Valor == ((NumeroPerfecto)obj).Valor;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }

        // Sobrecarga del operador de igualdad
        public static bool operator ==(NumeroPerfecto n1, NumeroPerfecto n2)
        {
            if (ReferenceEquals(n1, n2)) return true;
            if (ReferenceEquals(n1, null) || ReferenceEquals(n2, null)) return false;
            return n1.Valor == n2.Valor;
        }

        public static bool operator !=(NumeroPerfecto n1, NumeroPerfecto n2)
        {
            return !(n1 == n2);
        }

        // Sobrescribir ToString para mostrar el valor
        public override string ToString()
        {
            return Valor.ToString();
        }
    }

}
