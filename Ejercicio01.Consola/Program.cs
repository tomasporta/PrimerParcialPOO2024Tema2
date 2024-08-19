



namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cono cono = new Cono(3, 5);
                cono.InformarDatos();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
