using System;

public class StockPurchase
{
    public int PurchaseID { get; set; }
    public int Stock_SupplierID { get; set; }
    public Supplier Supplier { get; set; } // Navigation Property

    public int Stock_ProductID { get; set; }
    public Product Product { get; set; } // Navigation Property

    public DateTime PurchaseDate { get; set; }
    public int QuantityPurchased { get; set; }
    public decimal PurchasePrice { get; set; }
}
