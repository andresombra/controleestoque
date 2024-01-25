using Estoque.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            var model = new Usuario();

            model.Nome = "Andre Luiz Sombra";
            model.Senha = "123";

            return View(model);
        }
    }
}
