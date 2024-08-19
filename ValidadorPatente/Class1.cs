using System.Text.RegularExpressions;

namespace ValidadorPatente
{
    public class ValidadorPatente
    {
        // Método público para validar la patente
        public static bool Validar(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
            {
                return false;
            }

            return EsFormatoAntiguo(patente) || EsFormatoNuevo(patente);
        }

        // Método privado para verificar si la patente tiene el formato antiguo (AAA NNN)
        private static bool EsFormatoAntiguo(string patente)
        {
            // AAA NNN donde A es letra y N es número
            string patronAntiguo = @"^[A-Z]{3}\s[0-9]{3}$";
            return Regex.IsMatch(patente, patronAntiguo, RegexOptions.IgnoreCase);
        }

        // Método privado para verificar si la patente tiene el formato nuevo (AA NNN AA)
        private static bool EsFormatoNuevo(string patente)
        {
            // AA NNN AA donde A es letra y N es número
            string patronNuevo = @"^[A-Z]{2}\s[0-9]{3}\s[A-Z]{2}$";
            return Regex.IsMatch(patente, patronNuevo, RegexOptions.IgnoreCase);
        }
    }

    
}
