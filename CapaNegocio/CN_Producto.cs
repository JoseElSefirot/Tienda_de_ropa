using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();


        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public bool CambiarEstado(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            try
            {
                // Consulta la base de datos para obtener el producto con el ID proporcionado
                Producto productoExistente = Listar().FirstOrDefault(p => p.IdProducto == obj.IdProducto);

                if (productoExistente != null)
                {
                    // Cambia el estado del producto
                    productoExistente.Estado = false; // Cambia el estado a inactivo

                    // Llama al método Editar de la capa de datos para guardar los cambios en la base de datos
                    respuesta = Editar(productoExistente, out mensaje);
                }
                else
                {
                    mensaje = "El producto no existe.";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al cambiar el estado del producto: " + ex.Message;
            }

            return respuesta;
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }

        
    }
}
