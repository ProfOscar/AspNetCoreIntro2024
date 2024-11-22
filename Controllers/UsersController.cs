using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro2024.Controllers
{
    public class UsersController : Controller
    {
        private List<string> users = new List<string>
        { "Paperino", "Pippo", "Topolino", "Minnie"};

        public IActionResult Index()
        {
            string listToPrint = "Elenco Utenti:";
            foreach (var item in users)
            {
                listToPrint += $"\n{item}";
            }

            return Content(listToPrint);
        }

        public IActionResult Detail(int id)
        {
            string message = $"Sono Detail e ho ricevuto id: {id}";
            message += $"\nL'utente richiesto è {users[id]}";
            return Content(message);
        }
    }
}
