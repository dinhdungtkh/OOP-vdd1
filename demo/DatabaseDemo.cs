using dao;
using OOP_dung.vd.entity;

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
                db.InsertTable(tableName.product, new Product(i, $"Product {i}"));
                db.InsertTable(tableName.accessory, new Category(i, $"Category {i}"));
                db.InsertTable(tableName.accessory, new Accessory(i, $"Accessory {i}"));
            }
        }

        public void InsertTableTest()
        {
            var newProduct = new { id = 5, name = "New Product", categoryId = 3 };
            int index = db.InsertTable(tableName.product, newProduct);
            Console.WriteLine(newProduct.id + " " + newProduct.name + " " + newProduct.categoryId);
            Console.WriteLine($"Inserted Product at index: {index}");

        }

        public void SelectTableTest()
        {
            var data = db.SelectTable(tableName.product);
            var categorydata = db.SelectTable(tableName.category);
            var accessorydata = db.SelectTable(tableName.accessory);

            PrintTableTest(tableName.product, data);
            PrintTableTest(tableName.category, categorydata);
            PrintTableTest(tableName.accessory, accessorydata);
        }

        public void UpdateTableTest()
        {
            db.UpdateTable(tableName.product, new Product(2, "Product editted", 3));
            db.UpdateTableById(3, new Accessory(2, "Accessory new"));
        }

        public void DeleteTableTest()
        {
            db.DeleteTable(tableName.product, new Product(1));
            // db.DeleteTable(tableName.product, new Product(1, "Product 1"));
        }

        public void TruncateTableTest()
        {
            db.TruncateTable(tableName.product);
            Console.WriteLine("Truncated Product table.");
        }

        public void PrintTableTest(tableName name, dynamic data)
        {
            switch (name)
            {
                case tableName.product:

                    List<Product> dataProd = (List<Product>)data;
                    Console.WriteLine("-Product-");
                    foreach (Product product in dataProd)
                    {
                        if (product != null)
                            Console.WriteLine("id: " + product.id + " product name: " + product.name + " categoryID " + product.categoryId);
                    }
                    return;
                case tableName.category:
                    List<Category> dataCategory = (List<Category>)data;
                    Console.WriteLine("-Category-");
                    foreach (Category category in dataCategory)
                    {
                        if (category != null)
                            Console.WriteLine("id: " + category.id + " category name: " + category.name);
                    }
                    return;
                case tableName.accessory:
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

        //public static void Main(string[] args)
        //{

        //    DatabaseDemo databaseDemo = new DatabaseDemo();
        //    databaseDemo.InitDatabase();
        //    databaseDemo.InsertTableTest();
        //    databaseDemo.UpdateTableTest();
        //    databaseDemo.DeleteTableTest(); ;
        //    databaseDemo.SelectTableTest();
        //    databaseDemo.TruncateTableTest();
        //    databaseDemo.SelectTableTest();
        //}
    }
}