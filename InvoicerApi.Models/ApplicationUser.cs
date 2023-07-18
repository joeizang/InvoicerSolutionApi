using InvoicerApi.Kernel;
using Microsoft.AspNetCore.Identity;

namespace InvoicerApi.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";

    public Currency PreferredCurrency { get; set; }

    public List<Address> UserAddresses { get; set; }
    
    public List<UserInvoice> UserInvoices { get; set; }

    public List<PlatformInvoice> PlatformInvoices { get; set; }

    public ApplicationUser()
    {
        UserAddresses = new List<Address>();
        UserInvoices = new List<UserInvoice>();
        PlatformInvoices = new List<PlatformInvoice>();
    }
}