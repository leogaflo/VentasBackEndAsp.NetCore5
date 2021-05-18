using System;
using System.Collections.Generic;

#nullable disable

namespace WebSDigisoft.Model
{
    public partial class Concepto
    {
        public long Id { get; set; }
        public long IdSale { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public long IdProduct { get; set; }

        public virtual Producto IdProductNavigation { get; set; }
        public virtual Ventum IdSaleNavigation { get; set; }
    }
}
