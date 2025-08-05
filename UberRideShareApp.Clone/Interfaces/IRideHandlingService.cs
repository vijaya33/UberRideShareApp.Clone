using Microsoft.AspNetCore.Mvc;

namespace UberRideShareApp.Clone.Interfaces
{
    public interface IRideHandlingService
    {
        // Get list of assumed or available ride requests. 
        [HttpGet("/api/drivers/{id}/rides/assigned")]
        Task<ActionResult<List<RideDto>>> GetAssignedRides(Guid id)
        {
            // Implementation to retrieve assigned rides for the driver
            throw new NotImplementedException();
        }

        // Accept a ride request
        [HttpPost("/api/drivers/{id}/rides/{rideId}/accept")]
        Task<IActionResult> AcceptRide(Guid id, Guid rideId)
        {
            // Implementation to accept a ride request
            throw new NotImplementedException();
        }

        // Decline a ride request
        [HttpPost("/api/drivers/{id}/rides/{rideId}/decline")]
        Task<IActionResult> DeclineRide(Guid id, Guid rideId);

        // Start a ride (passenger picked up)
        [HttpPost("/api/drivers/{id}/rides/{rideId}/start")]
        abstract public Task<IActionResult> StartRide(Guid id, Guid rideId);

        // Complete a ride (passenger dropped off)
        [HttpPost("/api/drivers/{id}/rides/{rideId}/complete")]
        Task<IActionResult> CompleteRide(Guid id, Guid rideId);


        // Cancel a ride (driver cancels before or during ride)
        [HttpPost("/api/drivers/{id}/rides/{rideId}/cancel")]
        Task<IActionResult> CancelRide(Guid id, Guid rideId);
    }
}
