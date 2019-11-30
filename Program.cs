using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Api_Fluente
 {
    using Clases;
    class Program
    {
        static void Main(string[] args)
        {
            /*
             El Api Fluente es un patron que elimina la Repeticion de Codigo a la hora de Llamar metodos de la misma Clase...

            Es Decir, Digamos que tengo una clase.. En este Ejemplo CEmpleado..

            En esta Clase tengo 2 metodos que tengo que llamar al Mismo Tiempo
            -> GetHorasTrabajadas()
            -> TieneBonificacion()
             Normalmente yo esto haria de la siguiente Forma
             instancia_de_Clase.GetHorasTrabajadas();
             instancia_de_Clase.TieneBonificacion();
             En El Patron de api Fluente Normalmente Llamo Los metodos en cadena.. Por Rango de Llamadas..
             Como programador y lógica de mi codigo.. 

            Se que Cree al metodo de GetHorasTrabajas() para ser llamado primero que el metodo TieneBonificacion()

            Lo que hago como buen programador es llamar a los metodos por jerarquia..

            La pregunta es ¿Como llevo a cabo esta Practica...?
            Muy Simple. aqui comento el codigo para que pueda entenderse Mejor..
             */

            var CurrentCompany = new CEmpresa("Test of Name of Company..", 500);
            CurrentCompany.AgregarEmpleado(new CEmpleado() {
                Nombre="Oscar Daniel Gomez Reyes",
                Sueldo=600,
                HorasTrabajada=8
            });
            CurrentCompany.AgregarEmpleado(new CEmpleado()
            {
                Nombre = "Joel Mendez",
                Sueldo = 700,
                HorasTrabajada = 12
            });

            CurrentCompany.GetAllEmployees().ForEach(x => {
                x.GetHorasTrabajadas().TieneBonificacion();
                Console.WriteLine("-----");
            });
            Console.WriteLine(CurrentCompany);
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
    }
}
