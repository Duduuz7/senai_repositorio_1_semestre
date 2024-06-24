using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_ASP.NET_MVC.Infra;
using Projeto_Gamer_ASP.NET_MVC.Models;

namespace Projeto_Gamer_ASP.NET_MVC.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = context.Jogador.ToList();
            ViewBag.Equipe = context.Equipe.ToList();
            
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form) {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());
            novoJogador.Equipe = context.Equipe.First(x => x.IdEquipe == novoJogador.IdEquipe);

            context.Jogador.Add(novoJogador);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id) {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Equipe = context.Equipe.ToList();
            Jogador jogador = context.Jogador.First(x => x.IdJogador == id);
            ViewBag.Jogador = jogador;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador jogador) {
            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());
            novoJogador.Equipe = context.Equipe.First(x => x.IdEquipe == novoJogador.IdEquipe);

            Jogador jogadorBuscado = context.Jogador.First(x => x.IdJogador == novoJogador.IdJogador);

            jogadorBuscado.Nome = novoJogador.Nome;
            jogadorBuscado.Email = novoJogador.Email;
            jogadorBuscado.Senha = novoJogador.Senha;
            jogadorBuscado.IdEquipe = novoJogador.IdEquipe;
            jogadorBuscado.Equipe = novoJogador.Equipe;

            context.Jogador.Update(jogadorBuscado);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id) {
            Jogador jogador = context.Jogador.First(x => x.IdJogador == id);

            context.Jogador.Remove(jogador);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public static implicit operator JogadorController(Jogador v)
        {
            throw new NotImplementedException();
        }
    }
}