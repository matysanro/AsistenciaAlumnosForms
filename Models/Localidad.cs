using AsistenciaAlumnosForms.Models;

namespace AsistenciaAlumnosForms.Models
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }

        // Relaciones
        public ICollection<Alumno> Alumnos { get; set; }
        public ICollection<Profesor> Profesores { get; set; }
    }
}
