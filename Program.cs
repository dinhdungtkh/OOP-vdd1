using System;
using demo;
using dao;

public class Program
{
    public static void Main(string[] args) {
        //ProductDemo productDemo = new ProductDemo();
        //Product product = new Product(1, "Tokyha", 100);
        //productDemo.PrintProduct(product);


        DatabaseDemo databaseDemo= new DatabaseDemo();
        //databaseDemo.InitDatabase();
        databaseDemo.InsertTableTest();
        databaseDemo.UpdateTableTest();
        databaseDemo.SelectTableTest();
       // databaseDemo.TruncateTableTest();
    }
}