using Prueba2.Models;
using System.Collections.Generic;

namespace Prueba2.Interface
{
    /// <summary>
    /// Interfaz que describe los metodos 
    /// para Agregar pacientes, elegir al paciente
    /// proximo a atencion por orden de prioridad
    /// y el inicio del servicio.
    /// </summary>
    public interface IPacient
    {
        List<PacientBase> Pacients { get; set; }
        List<PacientBase> PacientsAttended { get; set; }
        void AddPacient(PacientBase pacient);
        PacientBase PacientSelector();
        void IniciarServicio();
    }
}
