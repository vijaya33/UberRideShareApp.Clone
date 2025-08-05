using Microsoft.AspNetCore.Mvc;

namespace UberRideShareApp.Clone.Controllers
{
    public class VehicleAndStatusManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Update vehicle information. 
        [HttpPut("/api/drivers/vehicle")]
        Task<ActionResult<VehicleDto>> UpdateVehicleInfo(UpdateVehicleRequest request);

        // set driver online / offline (availability) 
        [HttpPost("api/drivers/{id}/status")]
        Task<ActionResult> UpdateDriverStatus(Guid id, DriverStatusUpdateRequest request);

        // Update current location. 
        [HttpPost("/api/drivers/{id}/location)"]
        Task<ActionResultLocationUpdateRequest>> UpdateLocation(Guid id, LocationUpdateRequest request);
    }

    }

