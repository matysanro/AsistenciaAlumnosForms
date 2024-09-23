using AsistenciaAlumnosForms.Models;
using System;

namespace AsistenciaAlumnosForms.Models
{
    public class Profesor
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public int? IdLocalidad { get; set; }
        public int? IdMateria { get; set; }
        public int? IdUsuario { get; set; }

        // Relaciones
        public Localidad Localidad { get; set; }
        public Materia Materia { get; set; }
        public Usuario Usuario { get; set; }
    }
}
