using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UberRideShareApp.Clone.Interfaces;

namespace UberRideShareApp.Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostRideActionsController : ControllerBase, IRideHandlingService, IPostRideActions
    {
        // Rate the driver
        [HttpPost("/api/rides/{rideId}/rate-driver")]
        public Task<IActionResult> RateDriver(Guid rideId, RateDriverRequest request)
        {
            // Implementation to rate the driver
            throw new NotImplementedException();
        }
        // Tip the driver
        [HttpPost("/api/rides/{rideId}/tip-driver")]
        public Task<IActionResult> TipDriver(Guid rideId, TipDriverRequest request)
        {
            // Implementation to tip the driver
            throw new NotImplementedException();
        }
    {
        // Get list of assumed or available ride requests.
        [HttpGet("/api/drivers/{id}/rides/assigned")]
        public Task<ActionResult<List<RideDto>>> GetAssignedRides(Guid id)
        {
            // Implementation to retrieve assigned rides for the driver
            throw new NotImplementedException();
        }
        // Accept a ride request
        [HttpPost("/api/drivers/{id}/rides/{rideId}/accept")]
        public Task<IActionResult> AcceptRide(Guid id, Guid rideId)
        {
            // Implementation to accept a ride request
            throw new NotImplementedException();
        }
        // Decline a ride request
        [HttpPost("/api/drivers/{id}/rides/{rideId}/decline")]
        public Task<IActionResult> DeclineRide(Guid id, Guid rideId)
        {
            // Implementation to decline a ride request
            throw new NotImplementedException();
        }
        // Start a ride (passenger picked up)
        [HttpPost("/api/drivers/{id}/rides/{rideId}/start")]
        public Task<IActionResult> StartRide(Guid id, Guid rideId)
        {
            // Implementation to complete a ride. 
            throw new NotImplementedException();
        }
        
        // Complete a ride (passenger dropped off)
        [HttpPost("/api/drivers/{id}/rides/{rideId}/complete")]
        public Task<IActionResult> CompleteRide(Guid id, Guid rideId)
        {
            // Implementation to complete a ride
            throw new NotImplementedException();
        }
        // Cancel a ride (driver cancels before or during ride)
        [HttpPost("/api/drivers/{id}/rides/{rideId}/cancel")]
        public Task<IActionResult> CancelRide(Guid id, Guid rideId)
        {
            // Implementation to cancel a ride
            throw new NotImplementedException();
        }
    }
}
