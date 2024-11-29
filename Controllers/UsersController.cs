using AspNetCoreIntro2024.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro2024.Controllers
{
    public class UsersController : Controller
    {
        private List<UserModel> users = new List<UserModel>
        {
            new UserModel(1, "Paolino", "Paperino", new DateTime(1934,7,5), "San Francisco"),
            new UserModel(2, "Giuseppe", "Garibaldi", new DateTime(1799,10,15), "Nizza"),
            new UserModel(3, "Camillo", "Cavour", new DateTime(1805,1,11), "Torino"),
            new UserModel(4, "Monica", "Bellucci", new DateTime(1968,9,20), "Bologna")
        };

        public IActionResult Index()
        {
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
