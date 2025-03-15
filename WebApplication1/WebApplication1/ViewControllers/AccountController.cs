using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.ViewControllers
{
    public class AccountController : Controller
    {
        UsuarioService servicio = new UsuarioService();

        #region Login vista
        [AllowAnonymous]
        async public Task<ViewResult> Login(string ReturnUrl)
        {
            return View(new Usuario
            {
                ReturnUrl = ReturnUrl
            });
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Usuario usuario, string returnUrl = "/")
        {

            var result = servicio.VerificarLogin(usuario);

            if (usuario == null)
            {
                ModelState.AddModelError("", "Usuario o contraseña no válidos.");
                return View();
            }

            var claims = new List<Claim>()
            {new Claim(ClaimTypes.Name, usuario.Nombre),};

            var identity = new ClaimsIdentity(claims, "Cookies");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("Cookies", principal);

            return Redirect(returnUrl);
        }
        #endregion
        #region Logout
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await HttpContext.SignOutAsync();
            return Redirect(returnUrl);//nos envia nuevamente al inicio login.
        }
        #endregion
    }
}
