using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UberRideShareApp.Clone.Models;

namespace UberRideShareApp.Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountManagementController : ControllerBase
    {
        // Register new passenger account. 
        [HttpPost)("/api/passengers/register")]
        Task<ActionResult<PassengerDto>> RegisterPassenger(RegisterPassengerRequest request);

        // Login 
        [HttpPost("/api/passengers/login")]
        Task<ActionResult<AuthTokenDto>> Login(LoginRequest request);

        // Update passenger profile info
        [HttpPost("/api/passengers/{id}")]
        Task<ActionResult<PassengerDto>> UpdateProfile(Guid id, UpdatePassengerRequest request);
    }
}

