using Microsoft.AspNetCore.Mvc;

namespace SignalRLiveStreaming.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect($"{Guid.NewGuid()}");
        }
        [HttpGet("/{roomId}")]
        public IActionResult Room(string roomId)
        {
            ViewBag.roomId = roomId;
            return View();
        }
    }
}
