using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers
{
    public class ClientController : BaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
