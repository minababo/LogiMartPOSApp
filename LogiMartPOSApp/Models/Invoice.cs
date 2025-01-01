using System;

public class Invoice
{
    public int InvoiceID { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalDiscount { get; set; }
    public DateTime DateRecorded { get; set; }

    public int In_UserID { get; set; }
    public User User { get; set; } // Navigation Property

    public int In_CustomerID { get; set; }
    public Customer Customer { get; set; } // Navigation Property
}
