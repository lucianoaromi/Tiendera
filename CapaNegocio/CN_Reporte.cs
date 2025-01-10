using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List<ReporteVenta> Venta(string fechainicio, string fechafin, int idusuario)
        {
            return objcd_reporte.Venta(fechainicio, fechafin, idusuario);
        }


        // Nuevo método para cambiar el estado de entrega
        public bool CambiarEstadoEntrega(int idVenta, bool nuevoEstado, out string mensaje)
        {
            // Invoca el método de la capa de datos
            return objcd_reporte.ActualizarEstadoEntrega(idVenta, nuevoEstado, out mensaje);
        }
    }
}
