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
        private IAlunoBLL alunoBLL;
        public HomeController(IAlunoBLL _alunoBLL)
        {
            alunoBLL = _alunoBLL;
        }

        public IActionResult Index()
        {
            var alunos = alunoBLL.GetAlunos();

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
                //var _aluno = new AlunoBLL();
                alunoBLL.IncluirAluno(aluno);

                return RedirectToAction("Index");
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //AlunoBLL alunoBLL = new AlunoBLL();
            var aluno = alunoBLL.GetAlunos().Single(x => x.AlunoId == id);

            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                //var _aluno = new AlunoBLL();
                alunoBLL.AlterarAluno(aluno);

                return RedirectToAction("Index");
            }

        }

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    //alunoBLL.DeletarAluno(id);
        //    //return RedirectToAction("Index");

        //    var aluno2 = alunoBLL.GetAlunos().Single(a => a.AlunoId == id);

        //    return View(aluno2);
        //}

        [HttpPost]
        public IActionResult Delete(int id)
        {
            //alunoBLL.DeletarAluno(id);
            //return RedirectToAction("Index");

            alunoBLL.DeletarAluno(id);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var aluno = alunoBLL.GetAlunos().Single(a => a.AlunoId == id);

            return View(aluno);
        }

        public IActionResult Procurar(string procurarPor, string criterio)
        {
            if (criterio == null)
            {
                criterio = "";
            }

            if (procurarPor == "Email")
            {
                var aluno = alunoBLL.GetAlunos().SingleOrDefault(a => a.Email.ToLower() == criterio.ToLower());
                return View(aluno);
            }
            else
            {
                var aluno = alunoBLL.GetAlunos().SingleOrDefault(a => a.Nome.ToLower() == criterio.ToLower());
                return View(aluno);
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
