using Microsoft.AspNetCore.Mvc;
using NovoNar.Web.Models;
using System;

namespace NovoNar.Web.Controllers
{
    public class ClientController : Controller
    {
        [Route("client/new")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] Client client)
        {
            return View();
        }

        [Route("client/find/{cpf}")]
        public IActionResult Register(Int64 cpf)
        {
            return View();
        }
    }
}
