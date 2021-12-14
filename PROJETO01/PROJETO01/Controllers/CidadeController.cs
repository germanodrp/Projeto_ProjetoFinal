using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;

namespace PROJETO01.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index(int Cidade, string cidade)
        {
            var objeto = new Cidade();
            objeto.CidadeId = Cidade;
            objeto.Nome = cidade;


            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Estado = db.Estado.ToList();
            return View();
        }

        public IActionResult AdicionarConfirmacao(Cidade cidade)
        {
            var db = new Contexto();

            var obj = db.Cidade.FirstOrDefault(C => C.Nome == cidade.Nome);

            if (obj == null)
            {
                db.Cidade.Add(cidade);
            }
            else
            {
                obj.Nome = cidade.Nome;
                db.Cidade.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int CidadeID)
        {
            var db = new Contexto();
            ViewBag.Estado = db.Estado.ToList();
            var cidade = db.Cidade.First(item => item.CidadeId == CidadeID);
            return View("Adicionar", cidade);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeCidades = new Contexto().Cidade.ToList();

            return View(listaDeCidades);
        }

        public IActionResult Excluir(int CidadeID)
        {
            var db = new Contexto();
            var cidade = db.Cidade.First(c => c.CidadeId == CidadeID);
            db.Cidade.Remove(cidade);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
