using Microsoft.AspNetCore.Mvc;

namespace AdminTourismo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Lógica de verificación y manejo de inicio de sesión

            if (username == "admin" && password == "password123")
            {
                return RedirectToAction("Dashboard", "Account");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string username, string password, string confirmPassword)
        {
            // Aquí va la lógica para registrar un nuevo usuario.
            // Por ejemplo, validaciones, guardar en la base de datos, etc.
            // Falta por desarrollar

            if (password != confirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match.");
                return View();
            }

            // Aquí va la lógica para guardar el nuevo usuario en la base de datos.
            // Falta por desarrollar

            // Después de registrar, se redirige al usuario a la página de inicio de sesión.
            return RedirectToAction("Login");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            // Aquí va el envío del email con las instrucciones para restablecer la contraseña.
            // Falta por desarrollar

            return RedirectToAction("Login");
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}