using Finance_Api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginAdminController : Controller
    {
        Fin_dbContext db = new Fin_dbContext();

        [HttpGet]
        [Route("Listl")]
        public IActionResult Listl()
        {
            var data = from LoginAdmin in db.LoginAdmin select LoginAdmin;
            return Ok(data);
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Loginadmin([FromBody] User user)
        {

            var obj = db.LoginAdmin.SingleOrDefault(b => b.UserName == user.UserName && b.AccPassword == user.AccPassword);
            if (obj != null)
            {
                return Ok(obj);
            }
            return Unauthorized(obj);
        }
    }
}
