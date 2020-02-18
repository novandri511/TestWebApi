using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using percobaan.Model;

namespace web_test_api.Controllers
{
    [ApiController]
    [Route("table")]
    public class TableController : ControllerBase
    {
        private static List<Tablenya> Tables = new List<Tablenya>(){
            new Tablenya(){Id=1, Name="Check", Description="Percobaan pertama"},
        };
        

        private readonly ILogger<TableController> _logger;

        public TableController(ILogger<TableController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(Tables);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Tables.Find(e => e.Id == id));


        }

        [HttpPost]
        public IActionResult TableAdd(TableRequest user)
        {
            var userAdd = new Tablenya(){Id= user.Id, Name=user.Name, Description=user.Description};
            Tables.Add(userAdd);

            return Ok(userAdd);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTable(int id)
        {
            var userAdd = Tables.First(e => e.Id == id);
           Tables.Remove(userAdd);

            return Ok(userAdd);
        }
    }
}
