using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        // "objcd_usuario" es una instancia de la clase CD_Usuario llamada objcd_usuario
        private CD_Producto objcd_producto = new CD_Producto();

        //Mismo metodo "Listar" que se halla en la clase CD_Usuario de la capa de datos
        //Retorna la lista que posee la clase "CD_Usuario" que se encuentra en la capa de datos
        public List<Producto> Listar()
        {
            return objcd_producto.Listar();

        }

        //Puente de comunicacion con la "Capa de Presentacion"
        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el Codigo\n";
            }

            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el Nombre del producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario el Nombre del usuario\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_producto.Registrar(obj, out Mensaje);
            }
        }



        //Puente de comunicacion con la "Capa de Presentacion"
        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el documento\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Apellido del usuario\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario el Nombre del usuario\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_producto.Editar(obj, out Mensaje);
            }

        }


        //Puente de comunicacion con la "Capa de Presentacion"
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_producto.Eliminar(obj, out Mensaje);

        }
    }
}