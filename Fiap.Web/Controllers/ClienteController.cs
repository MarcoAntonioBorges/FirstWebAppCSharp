using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Controllers
{
    public class ClienteController : Controller
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
        public IActionResult Cadastrar(Cliente cliente)
        {
            ViewData["nome"] = cliente.Nome;
            ViewBag.cliente = cliente;
            TempData["msg"] = "Usuario cadastrado com sucesso!";
            return View();
        }
    }
}