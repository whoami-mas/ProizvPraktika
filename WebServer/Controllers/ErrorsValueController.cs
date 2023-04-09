using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServer.Models;

namespace WebServer.Controllers
{
    public class ErrorsValueController : ApiController
    {
        // GET api/ErrorsValue
        public IEnumerable<Errors> Get()
        {
            using(var db = new TechnicalSupportEntities())
            {
                return db.Errors.ToList();
            }
        }

        // GET api/ErrorsValue/5
        public Errors Get(int id)
        {
            using (var db = new TechnicalSupportEntities())
            {
                return db.Errors.FirstOrDefault(fi => fi.ID == id);
            }
        }

        // POST api/ErrorsValue
        public void Post([FromBody] Errors errorValue)
        {
            using (var db = new TechnicalSupportEntities())
            {
                errorValue.Status = "Получено";
                db.Errors.Add(errorValue);
                db.SaveChanges();
            }
        }

        // PUT api/ErrorsValue/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/ErrorsValue/5
        public void Delete(int id)
        {
        }
    }
}
