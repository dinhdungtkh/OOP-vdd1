using dao;
using OOP_dung.vd.dao;
using OOP_dung.vd.entity;

namespace OOP_dung.vd.demo

{
    public class ProductDaoDemo
    {
        private Database db;
        private ProductDAO demoproductDAO = new ProductDAO();

        public ProductDaoDemo()
        {
            db = Database.Instants;

            for (int i = 0; i < 10; i++)
            {
                db.InsertTable(tableName.product, new Product(i, $"Product {i}"));
            }
        }
        /// <summary>
        /// Tests the insertion of new Product objects into the database and displays the result.
        /// </summary>
        public void insertTest()
        {
            demoproductDAO.Insert(new Product(11, "Product new 11 ", 2));
            demoproductDAO.Insert(new Product(12, "Product new 12 ", 3));
            demoproductDAO.Insert(new Product(13, "Product new 13 ", 4));
            Console.WriteLine("After Insert:");
            findAllTest();
        }
        /// <summary>
        ///  Tests updating an existing Product object in the database and displays the result.
        /// </summary>
        public void updateTest()
        {
            demoproductDAO.Update(new Product(11, "Product Updated 11", 2));
            Console.WriteLine("After Update:");
            findAllTest();
        }
        /// <summary>
        /// Tests deleting an existing Product object from the database.
        /// </summary>
        public void deleteTest()
        {
            demoproductDAO.Delete(new Product(12, "{Product new 12", 3));

        }
        /// <summary>
        /// Displays all Product objects from the database.
        /// </summary>
        /// <returns></returns>
        public List<Product> findAllTest()
        {
            var products = demoproductDAO.FindAll();
            PrintTableTest(tableName.product, products);
            return products;
        }
        /// <summary>
        /// Tests finding a Product by its ID and displays the result.
        /// </summary>
        public void findByIdTest()
        {
            Console.WriteLine("Find by id Test ");
            Product products = demoproductDAO.FindById(11);

            if (products != null)
            {
                Console.WriteLine("Product ID : " + products.id);
                Console.WriteLine("Product Name : " + products.name);
                Console.WriteLine("Category ID : " + products.categoryId);
            }
            else Console.WriteLine("Product with Id not found");
        }
        /// <summary>
        /// Tests finding a Product by its name and displays the result.
        /// </summary>
        public void FindByNameTest()
        {
            Console.WriteLine("Find by name Test ");
            Product products = demoproductDAO.FindByName("Product new 12 ");

            if (products != null)
            {
                Console.WriteLine("Product ID : " + products.id);
                Console.WriteLine("Product Name : " + products.name);
                Console.WriteLine("Category ID : " + products.categoryId);
            }
            else Console.WriteLine("Product with Id not found");
        }

        // Search for products with names containing "1"
        public void searchTest()
        {

        }
        /// <summary>
        /// Prints the contents of the Product table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        public void PrintTableTest(tableName name, dynamic data)
        {
            List<Product> dataProduct = (List<Product>)data;
            Console.WriteLine("-Product-");
            foreach (Product product in dataProduct)
            {
                if (product != null)
                    Console.WriteLine("id: " + product.id + " Product name: " + product.name + " Category ID " + product.categoryId);
            }
        }

        public static void Main(string[] args)
        {

            ProductDaoDemo demo = new ProductDaoDemo();
            demo.insertTest();
            demo.updateTest();
            demo.deleteTest();
            demo.findByIdTest();
            demo.FindByNameTest();
            demo.findAllTest();
            demo.searchTest();
            Console.ReadLine();

        }

    }
}
