using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class Especie
    {
        public Especie()
        {
            Mascota = new HashSet<Mascota>();
        }

        public int IdEspecie { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
