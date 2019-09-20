using Introducao01.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;

namespace Introducao01.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            // o campo nome estiver vazio vai retornar a mensagem informando o erro
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatorio");
            }

            if(usuario.Senha != usuario.ConfimarSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");
            }
            //Se o estado do modelo for valido
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Victor",
                "Cleber",
                "Neiva"
            };

            // se os dados que esão no banco de dados forem diferentes no que ele digitou no formulario
            //
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}