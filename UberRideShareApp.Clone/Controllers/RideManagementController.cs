using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UberRideShareApp.Clone.Interfaces;

namespace UberRideShareApp.Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideManagementController : ControllerBase, IRideManagement
    {
        // Request a ride
        [HttpPost("/api/passengers/{id}/rides")]
        public Task<ActionResult<RideDto>> RequestRide(Guid id, RideRequest request)
        {
            // Implementation to request a ride
            throw new NotImplementedException();
        }
        // Track ride (get current ride status and driver location)
        [HttpGet("/api/passengers/{id}/current-ride")]
        public Task<ActionResult<RideStatusDto>> GetCurrentRideStatus(Guid id)
        {
            // Implementation to get current ride status
            throw new NotImplementedException();
        }
        // Cancel a ride
        [HttpPost("/api/passengers/{id}/current-ride/cancel")]
        public Task<IActionResult> CancelRide(Guid id)
        {
            // Implementation to cancel a ride
            throw new NotImplementedException();
        }

        // Cancel the Ride. 
        [HttpPost("/api/passengers/{id}/rides/{rideId}/cancel")]
        public Task<IActionResult> CancelRide(Guid id, Guid rideId)
        {
            // Implementation to cancel a specific ride
            throw new NotImplementedException();

            // Implementation to cancel a specific ride. 
            throw new NotImplementedException ();
        }
}
