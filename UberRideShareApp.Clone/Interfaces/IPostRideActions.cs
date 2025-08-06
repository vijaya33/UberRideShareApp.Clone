using Microsoft.AspNetCore.Mvc;

namespace UberRideShareApp.Clone.Interfaces
{
    public interface IPostRideActions
    {
        // Rate the driver
        [HttpPost("/api/rides/{rideId}/rate-driver")]
        Task<IActionResult> RateDriver(Guid rideId, RateDriverRequest request);

        // Tip the driver
        [HttpPost("/api/rides/{rideId}/tip-driver")]
        Task<IActionResult> TipDriver(Guid rideId, TipDriverRequest request);
    }
}
