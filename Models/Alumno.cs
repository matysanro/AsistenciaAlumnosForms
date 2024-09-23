using System;
using System.Collections.Generic;

namespace AsistenciaAlumnosForms.Models
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public int? IdLocalidad { get; set; }
        public int? IdCarrera { get; set; }
        public string Email { get; set; }

        // Relaciones
        public Localidad Localidad { get; set; }
        public Carrera Carrera { get; set; }
        public ICollection<MateriaAlumno> MateriasAlumnos { get; set; }
    }
}
