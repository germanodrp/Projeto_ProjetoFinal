using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class ClienteController : Controller
    {
       

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Cliente cliente)
        {
            var db = new Contexto();

            var obj = db.Cliente.FirstOrDefault(C => C.Nome == cliente.Nome);

            if (obj == null)
            {
                db.Cliente.Add(cliente);
            }
            else
            {
                obj.Nome = cliente.Nome;
                obj.Cpf = cliente.Cpf;
                obj.Email = cliente.Email;
                obj.Telefone= cliente.Telefone;
                obj.ClienteID= cliente.ClienteID;
                db.Cliente.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(string ClienteID)
        {
            var db = new Contexto();
            var cliente = db.Cliente.First(item => item.ClienteID == ClienteID);
            return View("Adicionar", cliente);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeClientes = new Contexto().Cliente.ToList();

            return View(listaDeClientes);
        }

        public IActionResult Excluir(string ClienteID)
        {
            var db = new Contexto();
            var cliente = db.Cliente.First(c => c.ClienteID == ClienteID);
            db.Cliente.Remove(cliente);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
