using System;

public class Program
{
    public static void Main(string[] args) {
        ProductDemo productDemo = new ProductDemo();
        Product product = new Product(1, "Tokyha", 100);
        productDemo.PrintProduct(product);
    }
}