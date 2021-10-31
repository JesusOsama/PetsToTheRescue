using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class Estado
    {
        public Estado()
        {
            Mascota = new HashSet<Mascota>();
        }

        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
