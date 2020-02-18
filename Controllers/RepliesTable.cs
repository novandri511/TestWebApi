// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using repliestable.Model;

// namespace web_test_api.Controllers
// {
//     [ApiController]
//     [Route("membertable")]
//     public class MemberTableController : ControllerBase
//     {
//         private static List<MemberTablenya> Tables = new List<MemberTablenya>(){
//             new MemberTablenya(){Id=1, Username="Tes", Password= "tes", Email="tes", Full_name="tes", Popularity="tes"},
//         };
        

//         private readonly ILogger<MemberTableController> _logger;

//         public MemberTableController(ILogger<MemberTableController> logger)
//         {
//             _logger = logger;
//         }

//         [HttpGet]
//         public IActionResult Get()
//         {
//            return Ok(Tables);
//         }

//         [HttpGet("{id}")]
//         public IActionResult GetById(int id)
//         {
//             return Ok(Tables.Find(e => e.Id == id));


//         }

//         [HttpPost]
//         public IActionResult TableAdd(MemberTable user)
//         {
           
        
//         var userAdd = new MemberTablenya(){Id= user.Id, Username = user.Username, Password = user.Password , Email = user.Email, Full_name = user.Full_name};
//         Tables.Add(userAdd);

//         return Ok(userAdd);
//         }
//         [HttpDelete("{id}")]
//         public IActionResult DeleteTable(int id)
//         {
//             var userAdd = Tables.First(e => e.Id == id);
//            Tables.Remove(userAdd);

//             return Ok(userAdd);
//         }
//     }
// }