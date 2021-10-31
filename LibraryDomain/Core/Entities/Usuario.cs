using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Mascota = new HashSet<Mascota>();
            RegistroAdopcionIdDueñoAntiguoNavigation = new HashSet<RegistroAdopcion>();
            RegistroAdopcionIdDueñoNuevoNavigation = new HashSet<RegistroAdopcion>();
            RegistroMascotaEncontrada = new HashSet<RegistroMascotaEncontrada>();
        }

        public string IdDni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public bool? Rol { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public int? IdUbigeo { get; set; }
        public byte[] Fotografia { get; set; }

        public virtual Ubigeo IdUbigeoNavigation { get; set; }
        public virtual ICollection<Mascota> Mascota { get; set; }
        public virtual ICollection<RegistroAdopcion> RegistroAdopcionIdDueñoAntiguoNavigation { get; set; }
        public virtual ICollection<RegistroAdopcion> RegistroAdopcionIdDueñoNuevoNavigation { get; set; }
        public virtual ICollection<RegistroMascotaEncontrada> RegistroMascotaEncontrada { get; set; }
    }
}
