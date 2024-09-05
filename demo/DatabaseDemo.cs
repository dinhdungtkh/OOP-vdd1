using dao;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace demo
{
    public class DatabaseDemo
    {
        private Database db;

        public DatabaseDemo()
        {
            db = Database.Instants;
            //InitDatabase();
        }

        public void InitDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                db.InsertTable("product", new Product (i, $"Product {i}" ));
                db.InsertTable("category", new { id = i, name = $"Category {i}" });
                db.InsertTable("accessory", new { id = i, name = $"Accessory {i}" });
            }
        }

        public void InsertTableTest()
        {
            var newProduct = new { id = 10, name = "New Product" };
            int index = db.InsertTable("product", newProduct);
            Console.WriteLine($"Inserted Product at index: {index}");
        }

        public void SelectTableTest()
        {
            var data = db.SelectTable("product");
            PrintTableTest("product", data);
           Console.WriteLine();

        }

        public void UpdateTableTest()
        {
            
        }

        public void DeleteTableTest()
        {
        
        }

        public void TruncateTableTest()
        {
            db.TruncateTable("product");
            Console.WriteLine("Truncated Product table.");
        }

        public void PrintTableTest(string tableName, dynamic data)
        {
            switch (tableName)
            {
                case "product":
                    List<Product> dataProd = (List<Product>) data;
                    foreach (Product product in dataProd)
                    {
                        if (product != null)
                            Console.WriteLine(product.name + "/n");
                    }
                    return;
                //case "category":
                //    return categoryTable;
                //case "accessory":
                //    return accessoryTable;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }

        
    }
}