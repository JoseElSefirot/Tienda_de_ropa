using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();


        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public bool CambiarEstado(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            try
            {
                // Consulta la base de datos para obtener el proveedor con el ID proporcionado
                Proveedor proveedorExistente = Listar().FirstOrDefault(p => p.IdProveedor == obj.IdProveedor);

                if (proveedorExistente != null)
                {
                    // Cambia el estado del proveedor
                    proveedorExistente.Estado = !proveedorExistente.Estado; // Cambia el estado

                    // Llama al método Editar de la capa de datos para guardar los cambios en la base de datos
                    respuesta = objcd_Proveedor.Editar(proveedorExistente, out mensaje);
                }
                else
                {
                    mensaje = "El proveedor no existe.";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al cambiar el estado del proveedor: " + ex.Message;
            }

            return respuesta;
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario la correo del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Proveedor obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario la correo del Proveedor\n";
            }



            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }


        }


        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
