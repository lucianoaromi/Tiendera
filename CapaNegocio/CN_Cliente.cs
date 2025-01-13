using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        // "objcd_usuario" es una instancia de la clase CD_Usuario llamada objcd_usuario
        private CD_Cliente objcd_cliente = new CD_Cliente();

        //Mismo metodo "Listar" que se halla en la clase CD_Usuario de la capa de datos
        //Retorna la lista que posee la clase "CD_Usuario" que se encuentra en la capa de datos
        public List<Cliente> Listar()
        {
            return objcd_cliente.Listar();

        }

        //Puente de comunicacion con la "Capa de Presentacion"
        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.Apellido))
            {
                Mensaje += "Es necesario el Apellido del usuario\n";
            }

            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el Nombre del usuario\n";
            }

            if (string.IsNullOrEmpty(obj.Direccion))
            {
                Mensaje += "Es necesario la Direccion del usuario\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_cliente.Registrar(obj, out Mensaje);
            }
        }

        private bool EsNumero(string valor)
        {
            foreach (char c in valor)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        //Puente de comunicacion con la "Capa de Presentacion"
        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del usuario\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del usuario\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del usuario\n";
            }



            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_cliente.Editar(obj, out Mensaje);
            }

        }


        //Puente de comunicacion con la "Capa de Presentacion"
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_cliente.Eliminar(obj, out Mensaje);

        }
    }
}
