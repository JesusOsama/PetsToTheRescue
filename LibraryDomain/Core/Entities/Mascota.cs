using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class Mascota
    {
        public Mascota()
        {
            RegistroAdopcion = new HashSet<RegistroAdopcion>();
            RegistroMascotaEncontrada = new HashSet<RegistroMascotaEncontrada>();
        }

        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public string Tamaño { get; set; }
        public string Edad { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaDeRegistro { get; set; }
        public bool? Sexo { get; set; }
        public int? IdUbigeo { get; set; }
        public int? IdEstado { get; set; }
        public int? IdEspecie { get; set; }
        public string IdUsuario { get; set; }
        public byte[] Fotografia { get; set; }

        public virtual Especie IdEspecieNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Ubigeo IdUbigeoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<RegistroAdopcion> RegistroAdopcion { get; set; }
        public virtual ICollection<RegistroMascotaEncontrada> RegistroMascotaEncontrada { get; set; }
    }
}
