using Microsoft.AspNetCore.Mvc;
using UberRideShareApp.Clone.Interfaces;


namespace UberRideShareApp.Clone.Controllers
{
    public class SupportController : ControllerBase, ISupport
    {
        public IActionResult Index()
        {
            return View();
        }
        // Contact Uber support 
        [HttpPost("/api/passengers/{id}/support")]
        public Task<IActionResult> ContactSupport(Guid id, SupportRequest request)
        {
            // Implementation to contact Uber support
            throw new NotImplementedException();

        }

        [HttpGet("/api/passengers/{id}/support/GetSupportHistory")]
        public Task<ActionResult<List<Support>>> GetSupportHistory(Guid id)
        {
            // Implementation to get support history
            throw new NotImplementedException();

            // Implementation to get past Support tickets for the specific passenger.
            throw new NotImplementedException();
        } // End of method. 
    } // End of class. 
} // End of namespace. 
