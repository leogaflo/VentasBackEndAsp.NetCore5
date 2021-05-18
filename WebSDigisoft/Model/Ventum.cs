using System;
using System.Collections.Generic;

#nullable disable

namespace WebSDigisoft.Model
{
    public partial class Ventum
    {
        public Ventum()
        {
            Conceptos = new HashSet<Concepto>();
        }

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long IdClient { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente IdClientNavigation { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
    }
}
