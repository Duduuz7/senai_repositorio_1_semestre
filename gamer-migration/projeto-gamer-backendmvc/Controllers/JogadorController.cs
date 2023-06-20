using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_backendmvc.infra;
using projeto_gamer_backendmvc.Models;

namespace projeto_gamer_backendmvc.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form, Equipe e)
        {

            Jogador novoJogador = new Jogador();
            Equipe novaEquipe = new Equipe();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["Equipe"]);
            novoJogador.Equipe = c.Equipe.First(e => e.IdEquipe == int.Parse(form["Equipe"]));

            c.Jogador.Add(novoJogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");

        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador j = c.Jogador.First(x => x.IdJogador == id);

            c.Jogador.Remove(j);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/listar");

        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Jogador j = c.Jogador.First(x => x.IdJogador == id);

            ViewBag.Jogador = j;
            ViewBag.Equipe = c.Equipe.ToList();

            return View("Edit");
        }

        [Route("AtualizarJogador")]
        public IActionResult Atualizar(IFormCollection form)
        {

            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            Jogador jogador = c.Jogador.First(j => j.IdJogador == novoJogador.IdJogador);

            jogador.Nome = novoJogador.Nome;
            jogador.Senha = novoJogador.Senha;
            jogador.Email = novoJogador.Email;
            jogador.IdEquipe = novoJogador.IdEquipe;

            c.Jogador.Update(jogador);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

    }




















}