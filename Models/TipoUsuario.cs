using AsistenciaAlumnosForms.Models;

namespace AsistenciaAlumnosForms.Models
{
    public class TipoUsuario
    {
        public int IdTipoUsuario { get; set; }
        public string Tipo { get; set; }

        // Relaciones
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
