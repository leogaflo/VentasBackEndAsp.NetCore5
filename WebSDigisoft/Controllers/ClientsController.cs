using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSDigisoft.Model;
using WebSDigisoft.Model.Request;
using WebSDigisoft.Model.ViewModeling;

namespace WebSDigisoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

       private Provider prv = new Provider();
       private Request request = new Request();
        [HttpGet]
        public IActionResult GetClient()
        {
            
            try
            {
                    prv.ProvidersCliente();
                    var dataset = prv.data;
                    request.Code = 1;
                    request.data = dataset;   
            }
            catch (Exception ex)
            {
                request.message = ex.Message;
            }

            return Ok(request);
        }
     
        [HttpPost]
        public IActionResult AddClient(ClientesRequest RCliente)
        {
            
            try
            {
                using (DigisoftContext db = new DigisoftContext())
                {
                    Cliente cliente = new Cliente();
                    cliente.Name = RCliente.Name;
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                    request .Code = 1;
                }
            }
            catch (Exception e)
            {
                request.message = e.Message;   
            }

            return Ok(request);
        }

        [HttpPut]
        public IActionResult EditClient(ClientesRequest RCliente)
        {

            try
            {
                using (DigisoftContext db = new DigisoftContext())
                {
                    Cliente cliente = db.Clientes.Find(RCliente.id);
                    cliente.Name = RCliente.Name;
                    db.Entry(RCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    request.Code = 1;
                }
            }
            catch (Exception e)
            {
                request.message = e.Message;
            }

            return Ok(request);
        }

        [HttpDelete]
        [Route("api/[controller]/id")]
        public IActionResult DeleteClient(long id)
        {

            try
            {
                using (DigisoftContext db = new DigisoftContext())
                {
                    Cliente cliente = db.Clientes.Find(id);
                    db.Remove(cliente);
                    db.SaveChanges();
                    request.Code = 1;
                }
            }
            catch (Exception e)
            {
                request.message = e.Message;
            }

            return Ok(request);
        }
    }

}
