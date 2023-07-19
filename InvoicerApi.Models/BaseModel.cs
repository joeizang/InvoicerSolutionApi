namespace InvoicerApi.Models;

public abstract class BaseModel
{
    public BaseModel()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTimeOffset.UtcNow;
        UpdatedAt = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset UpdatedAt { get; set; }
    
}