using Prueba2.Models;
using System;

namespace Prueba2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Creacion del objeto admin
            PacientAdmin admin = new PacientAdmin();

            //Agregado de pacientes
            admin.AddPacient(new PacientBase("Carlos", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(5)));
            admin.AddPacient(new PacientBase("Miguel", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(10)));
            admin.AddPacient(new PacientBase("Jose", Enumerators.EPriority.Rojo, DateTime.Now.AddMinutes(15)));
            admin.AddPacient(new PacientBase("Ernesto", Enumerators.EPriority.Amarillo, DateTime.Now.AddMinutes(25)));
            admin.AddPacient(new PacientBase("Juan", Enumerators.EPriority.Rojo, DateTime.Now.AddMinutes(30)));
            admin.AddPacient(new PacientBase("Miguel", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(35)));
            admin.AddPacient(new PacientBase("Erney", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(40)));
            admin.AddPacient(new PacientBase("Luis", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(45)));
            admin.AddPacient(new PacientBase("Miranda", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(50)));
            admin.AddPacient(new PacientBase("Martha", Enumerators.EPriority.Verde, DateTime.Now.AddMinutes(55)));
            admin.AddPacient(new PacientBase("Elias", Enumerators.EPriority.Rojo, DateTime.Now.AddMinutes(60)));
            admin.AddPacient(new PacientBase("Maria", Enumerators.EPriority.Amarillo, DateTime.Now.AddMinutes(65)));
            admin.AddPacient(new PacientBase("Alan", Enumerators.EPriority.Rojo, DateTime.Now.AddMinutes(70)));

            //Arrancado del servicio
            admin.IniciarServicio();

            Console.ReadLine();
        }
    }
}
