using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Api_Fluente.Clases
{
   public class CEmpleado
    {
        public string Nombre { get; set; }
        public string CIN { get; set; }
        public decimal Sueldo { get; set; }
        public int HorasTrabajada { get; set; }
        public int? HorasExtras = null;
        public decimal Bonificacion;

        //Bueno Lo Primero es que.. Para poder hacer el desencadenamiento de Llamadas.. Debo devolver la Misma Instancia de la Clase..

            // Esto lo puedo hacer usando la palabra reservada This.. Que es como decir "Retorname Este"  Este es a la clase.. Pero con su instancia por supuesto..

        public CEmpleado GetHorasTrabajadas()
        {
            if (HorasTrabajada > CEmpresa.HoraDeTrabajoNormal)
                HorasExtras = HorasTrabajada - CEmpresa.HoraDeTrabajoNormal;
            return this;
        }
        public CEmpleado TieneBonificacion()
        {
            //Primero... Codigo a ejecutar.. Normal..
            #region Codigo a Ejecutar
            if (HorasExtras != null)
            {
                if (HorasExtras > 0)
                {
                    Bonificacion = CEmpresa.Bonificacion_HorasExtras * HorasExtras ?? 0;
                    Console.WriteLine($"El Trabajador {Nombre} Tiene {HorasExtras} Horas de Trabajo Extra\ny una Bonificación de {Bonificacion}");
                }
            }
            else
                Console.WriteLine($"El Empleado {Nombre} no tiene ninguna hora Extra Trabajada");
            #endregion
            //Retornar la instancia... ¿Esto para que? para no salir del contexto y poder volver a usar ese retorno en terminos de esa instancia...
            return this;
        }
    }
}
