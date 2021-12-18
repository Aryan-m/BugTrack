using DataAccess.Data;
using DataAccess.DbAccess;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTrackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        // dependency injection
        private readonly IBugsData _bugsDB;

        public BugsController(IBugsData bugsDB)
        {
            _bugsDB = bugsDB;
        }

        // GET api/<BugsController>/5
        [HttpGet]
        public async Task<IEnumerable<BugModel>> Get(long id = 0)
        {
            return await _bugsDB.View(id);
        }

        // POST api/<BugsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BugsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BugsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
