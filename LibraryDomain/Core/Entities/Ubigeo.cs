using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDomain.Core.Entities
{
    public partial class Ubigeo
    {
        public Ubigeo()
        {
            Mascota = new HashSet<Mascota>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdUbigeo { get; set; }
        public string Region { get; set; }
        public string Departamento { get; set; }
        public string Distrito { get; set; }

        public virtual ICollection<Mascota> Mascota { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
