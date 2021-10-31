using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class RegistroMascotaEncontrada
    {
        public int IdRegistroMe { get; set; }
        public string IdDni { get; set; }
        public int? IdMascota { get; set; }
        public DateTime? FechaEncuentro { get; set; }
        public string LugarEncuentro { get; set; }

        public virtual Usuario IdDniNavigation { get; set; }
        public virtual Mascota IdMascotaNavigation { get; set; }
    }
}
