using Microsoft.AspNetCore.Mvc;

namespace UberRideShareApp.Clone.Interfaces
{
    public interface IRideManagement
    {
        // Request a ride
        [HttpPost("/api/passengers/{id}/rides")]
        Task<ActionResult<RideDto>> RequestRide(Guid id, RideRequest request);

        // Track ride (get current ride status and driver location)
        [HttpGet("/api/passengers/{id}/current-ride")]
        Task<ActionResult<RideStatusDto>> GetCurrentRideStatus(Guid id);

        // Cancel a ride
        [HttpPost("/api/passengers/{id}/current-ride/cancel")]
        Task<IActionResult> CancelRide(Guid id);

    }
}
