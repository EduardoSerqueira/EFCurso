using EFCurso.DataBase;
using EFCurso.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFCurso.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly EFCursoContext cursoContext;

        public FuncionarioController(EFCursoContext _cursoContext)
        {
            this.cursoContext = _cursoContext;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Salvar(Funcionario funcionario)
        {
            cursoContext.Funcionarios.Add(funcionario);
            cursoContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var funcionarios = cursoContext.Funcionarios.ToList();
            return View(funcionarios);
        }

        public IActionResult Editar(int id)
        {
            var funcionarios = cursoContext.Funcionarios.ToList();

            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Id == id)
                {
                    this.Salvar(funcionario);
                }
                else
                {
                    return View("/Shared/Error");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
