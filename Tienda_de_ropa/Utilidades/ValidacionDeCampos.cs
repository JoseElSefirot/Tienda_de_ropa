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
        }

        public bool ValidarNombreUsuario(string nombreUsuario)
        {
            // Verificar si el nombre de usuario contiene solo letras y números
            if (!Regex.IsMatch(nombreUsuario, @"^[a-zA-Z0-9]+$"))
            {
                return false;
            }

            // Verificar si la longitud del nombre de usuario es válida
            if (nombreUsuario.Length > 30)
            {
                return false;
            }

            return true;
        }

        public bool ValidarContraseña(string contraseña, int longitudMaxima)
        {
            // Verificar si la longitud de la contraseña es válida
            if (contraseña.Length > longitudMaxima)
            {
                return false;
            }

            return true;
        }


    }
}
