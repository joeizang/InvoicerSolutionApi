namespace InvoicerApi.Models;

public class Address : BaseModel
{
    public string Street { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Country { get; set; }

    public ApplicationUser User { get; set; }

    public Guid UserId { get; set; }
    
    public string FullAddress => $"{Street}, {City}, {ZipCode}, {Country}";
}