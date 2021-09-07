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

            // Validando com ModelState
            //if (string.IsNullOrEmpty(aluno.Nome))
            //    ModelState.AddModelError("Nome", "O Nome é obrigatório!");

            //if (string.IsNullOrEmpty(aluno.Sexo))
            //    ModelState.AddModelError("Sexo", "O Sexo é obrigatório!");

            //if (string.IsNullOrEmpty(aluno.Email))
            //    ModelState.AddModelError("Email", "O Email é obrigatório!");

            //if (aluno.Nascimento <= DateTime.Now.AddYears(-18))
            //    ModelState.AddModelError("Nascimento", "Data de Nascimento inválida!");

            if (!ModelState.IsValid)
            {
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
