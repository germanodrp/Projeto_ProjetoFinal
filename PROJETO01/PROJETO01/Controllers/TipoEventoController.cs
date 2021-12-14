using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class TipoEventoController : Controller
    {
        public IActionResult Index(int TiposEvento, string tiposEventos)
        {
            var objeto = new TipoEvento();
            objeto.TipoEventoID = TiposEvento;
            objeto.modelo = tiposEventos;

            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(TipoEvento tiposEventos)
        {
            var db = new Contexto();

            var obj = db.TipoEvento.FirstOrDefault(T => T.TipoEventoID == tiposEventos.TipoEventoID);

            if (obj == null)
            {
                db.TipoEvento.Add(tiposEventos);
            }
            else
            {
                obj.TipoEventoID = tiposEventos.TipoEventoID;
                obj.modelo = tiposEventos.modelo;
                db.TipoEvento.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int TipoEventoID)
        {
            var db = new Contexto();
            var tipoevento = db.TipoEvento.First(item => item.TipoEventoID == TipoEventoID);
            return View("Adicionar", tipoevento);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeTipoEvento = new Contexto().TipoEvento.ToList();

            return View(listaDeTipoEvento);
        }

        public IActionResult Excluir(int TipoEventoID)
        {
            var db = new Contexto();
            var TipoEvento = db.TipoEvento.First(T => T.TipoEventoID == TipoEventoID);
            db.TipoEvento.Remove(TipoEvento);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
