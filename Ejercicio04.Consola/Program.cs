using Ejercicio04.Datos;
using Ejercicio04.Entidades;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioNumerosPerfectos repo = new RepositorioNumerosPerfectos();

            while (true)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Agregar número perfecto");
                Console.WriteLine("2. Quitar número perfecto");
                Console.WriteLine("3. Mostrar números perfectos");
                Console.WriteLine("4. Buscar número perfecto");
                Console.WriteLine("5. Sumar todos los números perfectos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            if (NumeroPerfecto.EsPerfecto(numero))
                            {
                                var resultado = repo.AgregarNumeroPerfecto(new NumeroPerfecto(numero));
                                Console.WriteLine(resultado.Item2);
                            }
                            else
                            {
                                Console.WriteLine("El número ingresado no es perfecto.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese el número perfecto a quitar: ");
                        if (int.TryParse(Console.ReadLine(), out int numeroAQuitar))
                        {
                            var resultado = repo.QuitarNumeroPerfecto(new NumeroPerfecto(numeroAQuitar));
                            Console.WriteLine(resultado.Item2);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "3":
                        Console.WriteLine(repo.MostrarNumeros());
                        break;

                    case "4":
                        Console.Write("Ingrese el número perfecto a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int numeroABuscar))
                        {
                            var resultado = repo.BuscarNumero(new NumeroPerfecto(numeroABuscar));
                            if (resultado.Item1)
                            {
                                Console.WriteLine($"Número encontrado en la posición: {resultado.Item2}");
                            }
                            else
                            {
                                Console.WriteLine("Número no encontrado en el repositorio.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "5":
                        int suma = repo;
                        Console.WriteLine($"La suma de todos los números perfectos es: {suma}");
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

    }
    }

