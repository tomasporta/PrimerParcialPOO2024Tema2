using Ejercicio04.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Datos
{
     public class RepositorioNumerosPerfectos
    {
        // Atributo privado
        private int cantidad;

        // Atributo array para almacenar números perfectos
        private NumeroPerfecto[] numerosPerfectos;

        // Propiedad pública para obtener la cantidad
        public int Cantidad => cantidad;

        // Constructor con cantidad específica
        public RepositorioNumerosPerfectos(int cantidad)
        {
            this.cantidad = cantidad;
            numerosPerfectos = new NumeroPerfecto[cantidad];
        }

        // Constructor sin parámetros (por defecto 5)
        public RepositorioNumerosPerfectos() : this(5) { }

        // Método privado para verificar si el repositorio está completo
        private bool EstaCompleto()
        {
            return numerosPerfectos.All(x => x != null);
        }

        // Método privado para verificar si el repositorio está vacío
        private bool EstaVacio()
        {
            return numerosPerfectos.All(x => x == null);
        }

        // Método privado para verificar si un número ya existe en el repositorio
        private bool ExisteNumero(NumeroPerfecto numero)
        {
            return numerosPerfectos.Any(x => x == numero);
        }

        // Método para agregar un número perfecto
        public (bool, string) AgregarNumeroPerfecto(NumeroPerfecto numero)
        {
            if (EstaCompleto())
            {
                return (false, "El repositorio está completo.");
            }

            if (ExisteNumero(numero))
            {
                return (false, "El número ya existe en el repositorio.");
            }

            for (int i = 0; i < numerosPerfectos.Length; i++)
            {
                if (numerosPerfectos[i] == null)
                {
                    numerosPerfectos[i] = numero;
                    return (true, "Número agregado correctamente.");
                }
            }

            return (false, "No se pudo agregar el número.");
        }

        // Método para quitar un número perfecto
        public (bool, string) QuitarNumeroPerfecto(NumeroPerfecto numero)
        {
            for (int i = 0; i < numerosPerfectos.Length; i++)
            {
                if (numerosPerfectos[i] == numero)
                {
                    numerosPerfectos[i] = null;
                    return (true, "Número eliminado correctamente.");
                }
            }

            return (false, "El número no se encontró en el repositorio.");
        }

        // Método para acceder a un elemento por índice
        public NumeroPerfecto AccederElemento(int indice)
        {
            if (indice < 0 || indice >= numerosPerfectos.Length)
            {
                throw new IndexOutOfRangeException("Índice fuera de rango.");
            }
            return numerosPerfectos[indice];
        }

        // Método para mostrar todos los números almacenados
        public string MostrarNumeros()
        {
            if (EstaVacio())
            {
                return "No hay elementos almacenados todavía.";
            }

            return string.Join(", ", numerosPerfectos.Select(x => x?.ToString() ?? "Elemento Nulo"));
        }

        // Método para verificar si un número forma parte del repositorio
        public (bool, int) BuscarNumero(NumeroPerfecto numero)
        {
            for (int i = 0; i < numerosPerfectos.Length; i++)
            {
                if (numerosPerfectos[i] == numero)
                {
                    return (true, i);
                }
            }

            return (false, -1);
        }

        // Sobrecarga implícita para sumar todos los números del repositorio
        public static implicit operator int(RepositorioNumerosPerfectos repo)
        {
            return repo.numerosPerfectos.Where(x => x != null).Sum(x => x.Valor);
        }
    }
}
