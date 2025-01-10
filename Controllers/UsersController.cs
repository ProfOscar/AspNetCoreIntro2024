using AspNetCoreIntro2024.Models;
using AspNetCoreIntro2024.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro2024.Controllers
{
    public class UsersController : Controller
    {
        private IUsersService _usersService;

        public UsersController(IUsersService usersService) {
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            return View(_usersService.GetUsers());
        }

        public IActionResult Detail(int id)
        {
            //string message = message = $"Sono Detail e ho ricevuto id: {id}";
            //UserModel? user = _usersService.GetUserById(id);
            //if (user != null)
            //    message += $"\nL'utente richiesto è {user.Name}";
            //else
            //    message += "\nUtente non trovato";

            //return Content(message);
            return View(_usersService.GetUserById(id));
        }

        public IActionResult DeleteUser(int id)
        {
            int deleted = _usersService.DeleteUserById(id);
            // return Content($"Utente eliminato: {deleted}");
            return RedirectToAction("Index");
        }
    }
}
