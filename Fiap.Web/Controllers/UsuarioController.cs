using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            ViewData["nome"] = usuario.Nome;
            ViewData["dataNasc"] = usuario.DataNascimento;
            ViewData["email"] = usuario.Email;
            return View();
        }
    }
}