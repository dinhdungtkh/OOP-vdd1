using System;
public class ProductDemo {

    public void createProductest()
    {
        Product product = new Product(1, "TokyhaProductDemo", 10000);
    }
        
    public void PrintProduct (Product product)
    {
        Console.WriteLine (product.GetProductInfo());
    }
}