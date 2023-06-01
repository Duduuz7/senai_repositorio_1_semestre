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

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();

            //vem como string, o que precisamos é a imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();

            //aqui comeca a logica da insercao da imagem

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            //fim da logica de upload de imagem

            c.Equipe.Add(novaEquipe);

            //tambem funciona
            // c.Add(novaEquipe);

            //Salva alteracoes
            c.SaveChanges();


            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Equipe e = c.Equipe.First(x => x.IdEquipe == id);

            c.Equipe.Remove(e);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/listar");

        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            Equipe e = c.Equipe.First(x => x.IdEquipe == id);

            ViewBag.Equipe = e;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Equipe e)
        {

            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = e.Nome;

            // upload da imagem da equipe nova (atualizado)

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;

            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            Equipe equipe = c.Equipe.First(x => x.IdEquipe == e.IdEquipe);

            equipe.Nome = novaEquipe.Nome;
            equipe.Imagem = novaEquipe.Imagem;

            c.Equipe.Update(equipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}