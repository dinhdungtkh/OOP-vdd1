using dao;
using OOP_dung.vd.enitity;

namespace demo
{
    public class DatabaseDemo
    {
        private Database db;

        public DatabaseDemo()
        {
            db = Database.Instants;

        }

        public void InitDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                db.InsertTable("product", new Product(i, $"Product {i}"));
                db.InsertTable("category", new Category(i, $"Category {i}"));
                db.InsertTable("accessory", new Accessory(i, $"Accessory {i}"));
            }
        }

        public void InsertTableTest()
        {
            var newProduct = new { id = 5, name = "New Product" , categoryId = 3 };
            int index = db.InsertTable("product", newProduct);
           Console.WriteLine( newProduct.id +" " +  newProduct.name +" "+newProduct.categoryId);
           Console.WriteLine($"Inserted Product at index: {index}");
           
        }

        public void SelectTableTest()
        {
            var data = db.SelectTable("product");
            var categorydata = db.SelectTable("category");
            var accessorydata = db.SelectTable("accessory");

            PrintTableTest("product", data);
            PrintTableTest("category", categorydata);
            PrintTableTest("accessory", accessorydata);
        }

        public void UpdateTableTest()
        {
            db.UpdateTable("product", new Product(2, "Product editted" , 3));
            
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

                    List<Product> dataProd = (List<Product>)data;
                    Console.WriteLine("-Product-");
                    foreach (Product product in dataProd)
                    {
                        if (product != null)
                            Console.WriteLine("id: " + product.id + " product name: " + product.name + " categoryID " + product.categoryId);
                    }
                    return;
                case "category":
                    List<Category> dataCategory = (List<Category>)data;
                    Console.WriteLine("-Category-");
                    foreach (Category category in dataCategory)
                    {
                        if (category != null)
                            Console.WriteLine("id: " + category.id + " category name: " + category.name);
                    }
                    return;
                case "accessory":
                    List<Accessory> dataAccessory = (List<Accessory>)data;
                    Console.WriteLine("-Accessory");
                    foreach (Accessory accessory in dataAccessory)
                    {
                        if (accessory != null)
                            Console.WriteLine("id: " + accessory.id + " accessory name: " + accessory.name);
                    }
                    return;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }


    }
}