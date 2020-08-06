using Prueba2.Enumerators;
using System;

namespace Prueba2.Models
{
    /// <summary>
    /// Objeto Paciente que contiene las propiedades
    /// de un paciente
    /// </summary>
    public class PacientBase
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="Name">Nombre del paciente</param>
        /// <param name="Priority">Prioridad de atención</param>
        /// <param name="Arrival">Hora de llegada</param>
        public PacientBase(string Name, EPriority Priority, DateTime Arrival)
        {
            this.Name = Name;
            this.Priority = Priority;
            this.Arrival = Arrival;
        }

        /// <summary>
        /// Nombre del paciente
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Prioridad de atención
        /// </summary>
        public EPriority Priority { get; set; }
        /// <summary>
        /// Hora de llegada
        /// </summary>
        public DateTime Arrival { get; set; }
    }
}
