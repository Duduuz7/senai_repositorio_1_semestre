using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_ASP.NET_MVC.Infra;
using Projeto_Gamer_ASP.NET_MVC.Models;

namespace Projeto_Gamer_ASP.NET_MVC.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [Route("Login")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        [TempData]
        public string Message { get; set; }
        Context context = new Context();

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form) {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador jogadorBuscado = context.Jogador.FirstOrDefault(j => j.Email == email && j.Senha == senha)!;

            if (jogadorBuscado != null) { // se jogador existe
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome!);
                return LocalRedirect("~/");
            }
            Message="Dados inválidos, tente novamente!";

            return LocalRedirect("~/Login/Login");
        }

        [Route("Logout")]
        public IActionResult Logout() {
            // Remove a sessão do usuário
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}