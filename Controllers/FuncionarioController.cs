using EFCurso.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCurso.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Salvar(Funcionario funcionario)
        {
            return Content(funcionario.Nome + " - " + funcionario.Salario + " - " + funcionario.Cpf);
        }
    }
}
