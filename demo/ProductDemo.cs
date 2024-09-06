using OOP_dung.vd.entity;

namespace demo
{
    public class ProductDemo
    {

        public void createProductest()
        {
            Product product = new Product(1, "TokyhaProductDemo ", 10000);
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.GetProductInfo());
        }
        //public static void Main(string[] args)
        //{
        //    ProductDemo productDemo = new ProductDemo();
        //    Product product = new Product(1, "TokyhaProductDemo", 10000);
        //    productDemo.PrintProduct(product);
            
        //}

    }
}