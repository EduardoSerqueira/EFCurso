using EFCurso.DataBase;
using EFCurso.Models;
using Microsoft.AspNetCore.Mvc;

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
            return Ok();
        }
    }
}
