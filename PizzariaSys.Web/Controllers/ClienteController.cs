using PizzariaSys.Dominio.Interfaces;
using PizzariaSys.Dominio.Negocios;
using PizzariaSys.AcessoDados.Interface;
using PizzariaSys.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaSys.Dominio;

namespace PizzariaSys.Web.Controllers
{
    public class ClienteController: Controller {
        private IClienteNegocios _clienteNegocios = new ClienteNegocios();
        

        public ActionResult Index() {
            var clientes = _clienteNegocios.ListarTodos();
            return View(clientes);
        }
        [HttpGet]
        public ActionResult Inserir() {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(ClienteViewModel model) {
            
            if(!ModelState.IsValid){
                return View(model);
            }
            var cliente =  new Cliente{
                Nome = model.Nome,
                Logradouro  = model.Logradouro,
                Numero  = model.Numero,
                Bairro = model.Bairro,
                Telefone = model.Telefone            
            };

            _clienteNegocios.Salvar(cliente);

            return RedirectToAction("Index");
        }

    }
}