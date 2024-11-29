using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro2024.Controllers
{
    public class UsersController : Controller
    {
        private List<string> users = new List<string>
        { "Paperino", "Pippo", "Topolino", "Minnie"};

        public IActionResult Index()
        {
            //string listToPrint = "Elenco Utenti:";
            //foreach (var item in users)
            //{
            //    listToPrint += $"\n{item}";
            //}

            //return Content(listToPrint);
            return View(users);
        }

        public IActionResult Detail(int id)
        {
            string message = message = $"Sono Detail e ho ricevuto id: {id}";
            if (id > 0 && id < users.Count)
                message += $"\nL'utente richiesto è {users[id]}";
            else
                message += "\nUtente non trovato";

            return Content(message);
        }
    }
}
