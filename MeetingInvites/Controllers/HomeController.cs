using MeetingInvites.Models;
using System.Linq;
using System.Web.Mvc;

namespace MeetingInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //  Allows user to populate fields of FarmerResponse model object.
        public ActionResult Rsvp()
        {
            return View();
        }

        // Update repository and render view with Thanks
        [HttpPost]
        public ActionResult Rsvp(FarmerResponse response)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(response);
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
        }
        // Indicates Farmers who indicated they will attend.
        [ChildActionOnly]
        public ActionResult Attendees()
        {
            return View(Repository.Responses.Where(x => x.WillAttend == true));
        }
    }
}