using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tienda_de_ropa.Utilidades
{
    public class ValidacionDeCampos
    {
        public static class ValidacionUtils
        {
            public static bool ValidarLongitudUsuario(string nombreUsuario, int longitudMinima)
            {
                return nombreUsuario.Length >= longitudMinima;
            }

            public static bool ValidarLongitudContrasena(string contraseña, int longitudMinima)
            {
                return contraseña.Length >= longitudMinima;
            }

        }

        public bool ValidarNombreUsuario(string nombreUsuario)
        {
            if (!Regex.IsMatch(nombreUsuario, @"^[a-zA-Z0-9]+$"))
            {
                return false;
            }

            if (nombreUsuario.Length > 30)
            {
                return false;
            }

            return true;
        }

        public bool ValidarContraseña(string contraseña, int longitudMaxima)
        {
            
            if (contraseña.Length > longitudMaxima)
            {
                return false;
            }

            return true;
        }

        public bool ValidarCorreo(string email)
        {
            // Expresión regular para validar el formato del correo electrónico
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
