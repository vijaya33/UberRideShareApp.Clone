namespace UberRideShareApp.Clone.Models
{
    public class DTOs
    {

    }
    public class RegisterPassengerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class PaymentMethodRequest
    {
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CVC { get; set; }
        public string Type { get; set; } // CreditCard, PayPal, etc.
    }
    public class RideRequest
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string PaymentMethodId { get; set; }
    }
    public class RateDriverRequest
    {
        public int Rating { get; set; } // e.g. 1-5 stars
        public string Comment { get; set; }
    }

    public class TipDriverRequest
    {
        public decimal Amount { get; set; }
    }
    public class SupportRequest
    {
        public string Message { get; set; }
    }

    public class RegisterDriverRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public VehicleInfo Vehicle { get; set; }
    }

    public class UpdateDriverRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class UpdateVehicleRequest
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public int Year { get; set; }
    }

    public class DriverStatusUpdateRequest
    {
        public string Status { get; set; } // "online" or "offline"
    }

    public class LocationUpdateRequest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

}


