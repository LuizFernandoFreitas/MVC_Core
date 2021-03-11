using Microsoft.AspNetCore.Mvc;
using MVCBaseLayout_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBaseLayout_Crud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Aprova o menu principal
            return View();
        }

        public IActionResult ListaClientes()
        {
            // Mostra os clientes da aplicação
            return View(Dados.ListarClientes());
        }

        public IActionResult AdicionaCliente()
        {
            // Mostra os clientes da aplicação
            return View();
        }

        [HttpPost]
        public IActionResult AdicionaCliente(Cliente cliente)
        {
            Dados.AdicionarClientes(cliente);

            // Mostra os clientes da aplicação
            return RedirectToAction("ListaClientes");
        }

        public IActionResult EditarCliente(int id)
        {
            // Mostra os clientes da aplicação
            return View(Dados.EditarCliente(id));
        }

        [HttpPost]
        public IActionResult EditarCliente(Cliente cliente)
        {
            Dados.EditarCliente(cliente);

            // Mostra os clientes da aplicação
            return RedirectToAction("ListaClientes");
        }

        public IActionResult ExcluirCliente(int id)
        {
            Dados.ExcluirCliente(id);

            // Mostra os clientes da aplicação
            return RedirectToAction("ListaClientes");
        }
    }
}
