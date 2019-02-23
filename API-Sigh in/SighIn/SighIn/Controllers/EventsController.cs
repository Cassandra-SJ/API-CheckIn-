using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SighIn.demo;
using SighIn.demo.repositories;

namespace SighIn.Controllers
{
    [Produces("application/json")]
    [Route("api/Events")]
    public class EventsController : Controller
    {
        // GET: api/Events
        [HttpGet]
        public IEnumerable<Events> Get()
        {
            return this.repo .GetAll();//返回所有数据
        }

        // GET: api/Events/5
        [HttpGet("{id}", Name = "Get")]
        public Events Get(string  id)
        {
            return this.repo.Get(id);
        }
        private  EventsRepository repo = new EventsRepository();//var局部变量  换到全局变量要改变
        // POST: api/Events
        [HttpPost]
        public void Post(Events value)
        {
            
           this. repo.Add(value);
        }
        
        // PUT: api/Events/5
        [HttpPut("{id}")]
        public void Put(Events value)
        {
          
           this. repo.Update(value);//局部变量前要加this.但是不加效果也一样
            
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
       
            this.repo.Delete(id);

        }
    }
}
