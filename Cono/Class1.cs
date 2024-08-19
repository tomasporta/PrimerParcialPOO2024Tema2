namespace Cono
{
    public class Cono
    {
        public int Radio { get; }
        public int Altura { get; }

        // Atributo privado  para Generatriz
        private double Generatriz { get; }

        // Constructor del mismo 
        public Cono(int radio, int altura)
        {
            if (radio <= 0 || altura <= 0)
            {
                throw new ArgumentException("El radio y la altura deben ser mayores que 0.");
            }
            Radio = radio;
            Altura = altura;
            Generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            double areaBase = Math.PI * Math.Pow(Radio, 2);
            double areaLateral = Math.PI * Radio * Generatriz;
            return areaBase + areaLateral;
        }

        // Método para calcular el volumen
        public double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(Radio, 2) * Altura) / 3;
        }

        // Método para informar todos los datos
        public void InformarDatos()
        {
            Console.WriteLine($"Radio de la base: {Radio}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Generatriz: {Generatriz}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Volumen: {CalcularVolumen()}");
        }
    }

    }

