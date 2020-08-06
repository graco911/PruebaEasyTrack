using Prueba2.Interface;
using Prueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba2
{
    /// <summary>
    /// Clase que maneja la atencion de los empleados implementando la interfa IPacient
    /// </summary>
    public class PacientAdmin : IPacient
    {
        private List<PacientBase> _pacients;
        public List<PacientBase> Pacients
        {
            get => _pacients;
            set => _pacients = value;
        }

        private List<PacientBase> _pacientesAttended;

        public List<PacientBase> PacientsAttended
        {
            get { return _pacientesAttended; }
            set { _pacientesAttended = value; }
        }

        /// <summary>
        /// Metodo que permite agregar pacientes a la lista de espera
        /// </summary>
        /// <param name="pacient">Objeto paciente</param>
        public void AddPacient(PacientBase pacient)
        {
            if (Pacients == null)
            {
                Pacients = new List<PacientBase>();
            }

            //Agregamos al paciente a la lista de espera
            Pacients.Add(pacient);

            Console.WriteLine(string.Format("El Paciente {0} ha sido ingresado", pacient.Name));
        }


        /// <summary>
        /// Metodo que arranca la atención de los pacientes
        /// </summary>
        public void IniciarServicio()
        {
            Console.WriteLine("Iniciando Servicio de consultas");
            Console.WriteLine("Recepcion de pacientes");

            // Lista de control
            var listAux = Pacients;

            while (listAux.Count > 0)
            {
                var pacientAttended = PacientSelector();

                if (PacientsAttended == null)
                {
                    PacientsAttended = new List<PacientBase>();
                }

                //Agregamos al paciente a la lista de pacientes atendidos
                PacientsAttended.Add(pacientAttended);

                //retiramos al paciente de la lista de espera
                listAux.Remove(pacientAttended);

                Console.WriteLine(string.Format("El paciente {0}, ha sido atendido. hora de llegada {1} \n Prioridad {2}", pacientAttended.Name, pacientAttended.Arrival.ToShortTimeString(), pacientAttended.Priority));

            }
        }

        /// <summary>
        /// Metodo que permite elegir al paciente proximo para atención
        /// </summary>
        /// <returns>El paciente que sera atendido por orden de prioridad</returns>
        public PacientBase PacientSelector()
        {
            // Validamos que existan pacientes
            if (Pacients.Count > 0)
            {
                //  Devolvemos al paciente por prioridad y orden de llegada
                if (Pacients.Where(a => a.Priority == Enumerators.EPriority.Rojo).Count() > 0)
                {
                    return Pacients.Where(a => a.Priority == Enumerators.EPriority.Rojo).OrderBy(a => a.Arrival).FirstOrDefault();
                }
                else if ((Pacients.Where(a => a.Priority == Enumerators.EPriority.Amarillo).Count() > 0))
                {
                    return Pacients.Where(a => a.Priority == Enumerators.EPriority.Amarillo).OrderBy(a => a.Arrival).FirstOrDefault();
                }
                else
                {
                    return Pacients.Where(a => a.Priority == Enumerators.EPriority.Verde).OrderBy(a => a.Arrival).FirstOrDefault();
                }
            }
            else
                return null;
        }
    }
}
