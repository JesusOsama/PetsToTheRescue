using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class RegistroAdopcion
    {
        public int IdRegistroAdop { get; set; }
        public int? IdMascota { get; set; }
        public string IdDueñoAntiguo { get; set; }
        public string IdDueñoNuevo { get; set; }
        public DateTime? FechaDeAdopcion { get; set; }

        public virtual Usuario IdDueñoAntiguoNavigation { get; set; }
        public virtual Usuario IdDueñoNuevoNavigation { get; set; }
        public virtual Mascota IdMascotaNavigation { get; set; }
    }
}
