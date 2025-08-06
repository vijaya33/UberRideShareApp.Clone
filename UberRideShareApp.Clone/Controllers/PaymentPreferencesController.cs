using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UberRideShareApp.Clone.Interfaces;

namespace UberRideShareApp.Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentPreferencesController : ControllerBase, IPaymentPerferences
    {
        // Add a payment method
        [HttpPost("/api/passengers/{id}/payment-methods")]
        public Task<ActionResult<PaymentMethodDto>> AddPaymentMethod(Guid id, PaymentMethodRequest request)
        {
            // Implementation to add a payment method
            throw new NotImplementedException();
        }
        // Set default payment method
        [HttpPut("/api/passengers/{id}/payment-methods/{paymentMethodId}/default")]
        public Task<IActionResult> SetDefaultPaymentMethod(Guid id, Guid paymentMethodId)
        {
            // Implementation to set default payment method
            throw new NotImplementedException();
        }
        // Remove a payment method
        [HttpDelete("/api/passengers/{id}/payment-methods/{paymentMethodId}")]
        public Task<IActionResult> RemovePaymentMethod(Guid id, Guid paymentMethodId)
        {
            // Implementation to remove a payment method
            throw new NotImplementedException();
        }
    }
}
