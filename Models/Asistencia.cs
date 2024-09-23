using System;

namespace AsistenciaAlumnosForms.Models
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int? IdMateriaAlumno { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }

        // Relaciones
        public MateriaAlumno MateriaAlumno { get; set; }
    }
}
