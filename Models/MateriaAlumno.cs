using AsistenciaAlumnosForms.Models;

namespace AsistenciaAlumnosForms.Models
{
    public class MateriaAlumno
    {
        public int IdMateriaAlumno { get; set; }
        public int? IdMateria { get; set; }
        public int? IdAlumno { get; set; }
        public int? CicloLectivo { get; set; }

        // Relaciones
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
        public ICollection<Asistencia> Asistencias { get; set; }
    }
}
