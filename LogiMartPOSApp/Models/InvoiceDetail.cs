public class InvoiceDetail
{
    public int InvoiceDetailsID { get; set; }

    public int InvoiceID { get; set; }
    public Invoice Invoice { get; set; } // Navigation Property

    public int ProductID { get; set; }
    public Product Product { get; set; } // Navigation Property

    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public int? DiscountID { get; set; }
    public Discount Discount { get; set; } // Navigation Property
    public decimal FinalPrice { get; set; }
}
