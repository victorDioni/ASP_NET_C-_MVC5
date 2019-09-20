using Introducao01.Models;
using System.Web.Mvc;

namespace Introducao01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa // criando obejto pessoa
            {
                PessoaId = 1,
                Nome = "Victor Dionizio Bernardo",
                Tipo = "Gerente"
            };

            // associação a uma view

            // enviando e recebendo requisições dentro de uma view
            return View(pessoa); //view tipada
        }

        public ActionResult Contatos()
        {
            return View();
        }

        //Uma requisição Http
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}