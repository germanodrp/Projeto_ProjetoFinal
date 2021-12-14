using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class BarController : Controller
    {
        public IActionResult Index(int Bar, string bar)
        {
           

            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Bar bar)
        {
            var db = new Contexto();

            var obj = db.Bar.FirstOrDefault(B => B.BarID == bar.BarID);

            if (obj == null)
            {
                db.Bar.Add(bar);
            }
            else
            {
                obj.cnpj = bar.cnpj;
                obj.nome = bar.nome;
                obj.localizacao = bar.localizacao;
                obj.numero = bar.numero;

                db.Bar.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int barID)
        {
            var db = new Contexto();
            var bar = db.Bar.First(item => item.BarID == barID);
            return View("Adicionar", bar);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeBares = new Contexto().Bar.ToList();

            return View(listaDeBares);
        }

        public IActionResult Excluir(int barID)
        {
            var db = new Contexto();
            var Bar = db.Bar.First(B => B.BarID == barID);
            db.Bar.Remove(Bar);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}

