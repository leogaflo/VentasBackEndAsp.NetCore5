using System;
using System.Collections.Generic;

#nullable disable

namespace WebSDigisoft.Model
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Ventum>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
