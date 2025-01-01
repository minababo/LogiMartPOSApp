public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
    public int Prod_CategoryID { get; set; }
    public int? Prod_DiscountID { get; set; }
}
