using System;
using System.Collections.Generic;

#nullable disable

namespace WebSDigisoft.Model
{
    public partial class Producto
    {
        public Producto()
        {
            Conceptos = new HashSet<Concepto>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Concepto> Conceptos { get; set; }
    }
}
