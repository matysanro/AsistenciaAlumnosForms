using AsistenciaAlumnosForms.Models;

namespace AsistenciaAlumnosForms.Models
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public int? IdCarrera { get; set; }
        public int? IdProfesor { get; set; }

        // Relaciones
        public Carrera Carrera { get; set; }
        public Profesor Profesor { get; set; }
        public ICollection<MateriaAlumno> MateriasAlumnos { get; set; }
    }
}
