using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSDigisoft.Model;

namespace WebSDigisoft.Controllers
{
    public class Provider
    {
               
        public object data { get; set; }

        public  void ProvidersCliente()
        {

            using (DigisoftContext db = new DigisoftContext())
            {
            data = db.Clientes.OrderByDescending(b=> b.Id).ToList();
            }
        }

        public void ProvidersVenta()
        {
            using (DigisoftContext db = new DigisoftContext())
            {
                data = db.Venta.ToList();
            }
        }
        public void ProvidersProducto()
        {
            using (DigisoftContext db = new DigisoftContext())
            {
                data = db.Productos.ToList();
            }
        }

       

    }
}
