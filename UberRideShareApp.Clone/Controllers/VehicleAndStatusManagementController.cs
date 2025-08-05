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

        // Set driver online / offline (availability) 
        // Returns status code 200 OK on success.
        [HttpPost("api/drivers/{id}/status")]
        Task<IActionResult> UpdateDriverStatus(Guid id, DriverStatusUpdateRequest request);

        // Update current location. 
        // Returns status code 200 OK on success. 
        [HttpPost("/api/drivers/{id}/location")]
        Task<IActionResult> UpdateLocation(Guid id, LocationUpdateRequest request);
    }

    }

