using Microsoft.AspNetCore.Mvc;

namespace UberRideShareApp.Clone.Interfaces
{
    public interface ISupport
    {
        // Contact Uber support
        [HttpPost("/api/passengers/{id}/support")]
        Task<IActionResult> ContactSupport(Guid id, SupportRequest request);

    }
}
