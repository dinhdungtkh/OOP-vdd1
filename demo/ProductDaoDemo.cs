using dao;
using OOP_dung.vd.dao;
using OOP_dung.vd.enitity;

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

        public void insertTest()
        {
            demoproductDAO.Insert(new Product(11, "Product new 11 " , 2));
            demoproductDAO.Insert(new Product(12, "Product new 12 " , 3));
            demoproductDAO.Insert(new Product(13, "Product new 13 " ,4));
            Console.WriteLine("After Insert:");
            findAllTest();
        }

        public void updateTest()
        {
            demoproductDAO.Update(new Product(11, "Product Updated 11" , 2));
            Console.WriteLine("After Update:");
            findAllTest();
        }

        public void deleteTest()
        {
            demoproductDAO.Delete(new Product(12, "{Product new 12" , 3));

        }

        public List<Product> findAllTest()
        {
            var products = demoproductDAO.findAll();
            PrintTableTest(tableName.product, products);
            return products;
        }

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

        //public static void Main(string[] args)
        //{

        //    ProductDaoDemo demo = new ProductDaoDemo();
        //    demo.insertTest();
        //    demo.updateTest();
        //    demo.deleteTest();
        //    demo.findByIdTest();
        //    demo.FindByNameTest();
        //    demo.findAllTest();
        //    Console.ReadLine();

        //}

    }
}
