using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_BusinnesObjects.Models;

namespace Mvc_BusinnesObjects.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var alunos = new AlunoBLL().GetAlunos();

            return View("Lista", alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {

            if (aluno?.Nome == null || aluno?.Email == null || aluno?.Sexo == null)
            {
                ViewBag.Erro = "Dados Inválidos!";
                return View();
            }
            else
            {
                var _aluno = new AlunoBLL();
                _aluno.IncluirAluno(aluno);

                return RedirectToAction("Index");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
