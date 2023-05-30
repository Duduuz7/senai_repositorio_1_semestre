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
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        //Instância do objeto da classe Context : acessa o banco de dados
        Context c = new Context();


        //              controller/action
        // http://localhost/Equipe/Listar
        [Route("Listar")]
        public IActionResult Index()
        {
            //"mochila" que contém a lista das equipes
            //podemos usar essa "mochila" na view de Equipe.
            ViewBag.Equipe = c.Equipe.ToList();

            //Retorna a view de equipe
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            novaEquipe.Nome = form["Imagem"].ToString();

            c.Equipe.Add(novaEquipe);

            //tambem funciona
            // c.Add(novaEquipe);

            //Salva alteracoes
            c.SaveChanges();

            ViewBag.Equipe = c.Equipe.ToList();

            return LocalRedirect("~/Equipe/Listar");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}