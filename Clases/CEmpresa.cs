using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Api_Fluente.Clases
{
   public class CEmpresa
    {
        public static decimal Bonificacion_HorasExtras = 0;
        public string NombreDeEmpresa { get; set; }
        public int CantidadDeEmpleados { get; set; }
        private List<CEmpleado> Empleados { get; set; }
        public static int HoraDeTrabajoNormal = 8;
        public CEmpresa(string empname,Decimal bonificacion_HorasExtras)
        {
            Empleados = new List<CEmpleado>();
            this.NombreDeEmpresa = empname;
            CantidadDeEmpleados = Empleados.Count;
            Bonificacion_HorasExtras = bonificacion_HorasExtras;
        }
        public void AgregarEmpleado(CEmpleado empleado)
        {
            Empleados.Add(empleado);
            CantidadDeEmpleados = Empleados.Count;
        }
        public List<CEmpleado> GetAllEmployees()
        {
            return this.Empleados;
        }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Nombre de La Empresa: {NombreDeEmpresa}")
                .AppendLine($"Cantidad de Empleados: {CantidadDeEmpleados}")
                .ToString();
        }
    }
}
