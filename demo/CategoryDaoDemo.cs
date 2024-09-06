using dao;
using OOP_dung.vd.entity;

namespace demo

{
    public class CategoryDaoDemo
    {
        private Database db;
        private CategoryDAO democategoryDAO = new CategoryDAO();

        public CategoryDaoDemo()
        {
            db = Database.Instants;

            for (int i = 0; i < 10; i++)
            {
                db.InsertTable(tableName.category, new Category(i, $"Category {i}"));
            }
        }

        public void insertTest()
        {
            democategoryDAO.Insert(new Category(11, "Category 11"));
            democategoryDAO.Insert(new Category(12, "Category 12"));
            democategoryDAO.Insert(new Category(13, "Category 13"));
            Console.WriteLine("After Insert:");
            findAllTest();
        }

        public void updateTest()
        {
            democategoryDAO.Update(new Category(11, "Category Updated 11"));
            Console.WriteLine("After Update:");
            findAllTest();
        }

        public void deleteTest()
        {
            democategoryDAO.Delete(new Category(12, "Category 13"));

        }

        public List<Category> findAllTest()
        {
            var categories = democategoryDAO.FindAll();
            PrintTableTest(tableName.category, categories);
            return categories;
        }

        public void findByIdTest()
        {
            Category category = democategoryDAO.FindById(11);

            if (category != null)
            {
                Console.WriteLine("Category ID : " + category.id);
                Console.WriteLine("Category Name : " + category.name);
            }
            else Console.WriteLine("Category with Id not found");
        }



        public void PrintTableTest(tableName name, dynamic data)
        {
            switch (name)
            {
                case tableName.category:
                    List<Category> dataCategory = (List<Category>)data;
                    Console.WriteLine("-Category-");
                    foreach (Category category in dataCategory)
                    {
                        if (category != null)
                            Console.WriteLine("id: " + category.id + " category name: " + category.name);
                    }
                    return;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }

        //public static void Main(string[] args)
        //{

        //CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
        //categoryDaoDemo.insertTest();
        //categoryDaoDemo.updateTest();
        //categoryDaoDemo.deleteTest();
        //categoryDaoDemo.findByIdTest();
        //categoryDaoDemo.findAllTest();
        //Console.ReadLine();

        //}

    }
}
