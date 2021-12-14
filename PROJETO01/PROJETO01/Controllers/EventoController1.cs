using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class EventoController1 : Controller
    {
        public IActionResult Index(int evento, string eventos)
        {
            var objeto = new evento();
            objeto.EventoID = evento;
            objeto.nome = eventos;

            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(evento eventos)
        {
            var db = new Contexto();

            var obj = db.evento.FirstOrDefault(e => e.nome == eventos.nome);

            if (obj == null)
            {
                db.evento.Add(eventos);
            }
            else
            {
                obj.nome = eventos.nome;
                db.evento.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int EventoID)
        {
            var db = new Contexto();
            var eventos = db.evento.First(item => item.EventoID == EventoID);
            return View("Adicionar", eventos);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeEvento = new Contexto().evento.ToList();

            return View(listaDeEvento);
        }

        public IActionResult Excluir(int EventoID)
        {
            var db = new Contexto();
            var evento = db.evento.First(E => E.EventoID == EventoID);
            db.evento.Remove(evento);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}

