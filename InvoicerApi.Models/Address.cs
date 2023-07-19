namespace InvoicerApi.Models;

public class Address : BaseModel
{
    public string Street { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string ZipCode { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public ApplicationUser User { get; set; } = default!;

    public Guid UserId { get; set; }
    
    public string FullAddress => $"{Street}, {City}, {ZipCode}, {Country}";
}