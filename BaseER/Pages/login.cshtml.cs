using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BaseER.Pages
{
    public class LoginModel : PageModel
    {
        // Esta propiedad guarda el mensaje de error si fallas la clave
        [BindProperty]
        public string ErrorMessage { get; set; } = "";

        // Se ejecuta cuando entras a la página por primera vez
        public void OnGet()
        {
            ErrorMessage = "";
        }

        // Se ejecuta cuando haces clic en el botón "INGRESAR"
        public IActionResult OnPost(string usuario, string password)
        {
            // Login temporal de prueba
            if (usuario == "admin" && password == "1234")
            {
                // Si es correcto, nos manda al Index (el panel que ya tienes)
                return RedirectToPage("Index");
            }

            // Si falla, llenamos el mensaje y nos quedamos en el Login
            ErrorMessage = "Usuario o contraseña incorrectos.";
            return Page();
        }
    }
}