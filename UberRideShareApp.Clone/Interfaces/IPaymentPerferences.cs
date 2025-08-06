using Microsoft.AspNetCore.Mvc;
using UberRideShareApp.Clone.Models;

namespace UberRideShareApp.Clone.Interfaces
{
    public interface IPaymentPerferences
    {
        // Add a payment method
        [HttpPost("/api/passengers/{id}/payment-methods")]
        Task<ActionResult<PaymentMethodDto>> AddPaymentMethod(Guid id, PaymentMethodRequest request);

        // Set default payment method
        [HttpPut("/api/passengers/{id}/payment-methods/{paymentMethodId}/default")]
        Task<IActionResult> SetDefaultPaymentMethod(Guid id, Guid paymentMethodId);

        // Remove a payment method
        [HttpDelete("/api/passengers/{id}/payment-methods/{paymentMethodId}")]
        Task<IActionResult> RemovePaymentMethod(Guid id, Guid paymentMethodId);
    }
}
