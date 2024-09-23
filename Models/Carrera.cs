using AsistenciaAlumnosForms.Models;

namespace AsistenciaAlumnosForms.Models
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }

        // Relaciones
        public ICollection<Alumno> Alumnos { get; set; }
        public ICollection<Materia> Materias { get; set; }
    }
}
