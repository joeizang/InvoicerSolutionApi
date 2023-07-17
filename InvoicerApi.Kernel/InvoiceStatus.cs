namespace InvoicerApi.Kernel;

public enum InvoiceStatus
{
    Draft = 1,
    Sent,
    Paid,
    Overdue,
    Cancelled
}