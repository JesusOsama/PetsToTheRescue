using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class RegistroMascotaEncontradas
    {
        public int? IdRegistroMe { get; set; }
        public string IdUsuario { get; set; }
        public int? IdMascota { get; set; }
        public DateTime? FechaDeEncuentro { get; set; }
        public string LugarDeEncuentro { get; set; }

        public virtual Mascota IdMascotaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
