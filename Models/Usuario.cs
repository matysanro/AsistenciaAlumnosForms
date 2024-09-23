using AsistenciaAlumnosForms.Models;

namespace AsistenciaAlumnosForms.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public int? IdTipoUsuario { get; set; }

        // Relaciones
        public TipoUsuario TipoUsuario { get; set; }
        public ICollection<Profesor> Profesores { get; set; }
    }
}
