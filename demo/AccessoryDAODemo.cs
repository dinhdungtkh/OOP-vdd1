using dao;
using OOP_dung.vd.dao;
using OOP_dung.vd.entity;

namespace OOP_dung.vd.demo
{
    public class AccessoryDAODemo
    {
        private Database db;
        private AccessoryDAO demoaccessoryDAO = new AccessoryDAO();

        public AccessoryDAODemo()
        {
            db = Database.Instants;

            for (int i = 0; i < 10; i++)
            {
                db.InsertTable(tableName.accessory, new Accessory(i, $"Accessory {i}"));
            }
        }
        /// <summary>
        /// Tests the insertion of new Accessory objects into the database and displays the results.
        /// </summary>
        public void insertTest()
        {
            demoaccessoryDAO.Insert(new Accessory(11, "Accessory 11"));
            demoaccessoryDAO.Insert(new Accessory(12, "Accessory 12"));
            demoaccessoryDAO.Insert(new Accessory(13, "Accessory 13"));
            Console.WriteLine("After Insert:");
            findAllTest();
        }
        /// <summary>
        /// Tests updating an existing Accessory object in the database and displays the results.
        /// </summary>
        public void updateTest()
        {
            demoaccessoryDAO.Update(new Accessory(11, "Accessory Updated 11"));
            Console.WriteLine("After Update:");
            findAllTest();
        }
        /// <summary>
        /// Tests deleting an Accessory object from the database and displays the results.
        /// </summary>
        public void deleteTest()
        {
            demoaccessoryDAO.Delete(new Accessory(12, "Accessory 13"));

        }
        /// <summary>
        /// Displays all Accessory objects from the database.
        /// </summary>
        /// <returns></returns>
        public List<Accessory> findAllTest()
        {
            var accessory = demoaccessoryDAO.FindAll();
            PrintTableTest(tableName.accessory, accessory);
            return accessory;
        }

        /// <summary>
        /// Displays an Accessory object by its ID.
        /// </summary>
        public void findByIdTest()
        {
            Accessory accessory = demoaccessoryDAO.FindById(11);

            if (accessory != null)
            {
                Console.WriteLine("Accessory ID : " + accessory.id);
                Console.WriteLine("Accessory Name : " + accessory.name);
            }
            else Console.WriteLine("Accessory with Id not found");
        }

        /// <summary>
        ///  Prints the details of Accessory objects or throws an exception if the table name is invalid.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentException"></exception>

        public void PrintTableTest(tableName name, dynamic data)
        {
            List<Accessory> dataAccessory = (List<Accessory>)data;
            Console.WriteLine("-Accessory-");
            foreach (Accessory accessory in dataAccessory)
            {
                if (accessory != null)
                    Console.WriteLine("id: " + accessory.id + " accessory name: " + accessory.name);
            }
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        //public static void Main(string[] args)
        //{

        //    AccessoryDAODemo accessoryDAODemo = new AccessoryDAODemo();
        //    accessoryDAODemo.insertTest();
        //    accessoryDAODemo.updateTest();
        //    accessoryDAODemo.deleteTest();
        //    accessoryDAODemo.findByIdTest();
        //    accessoryDAODemo.findAllTest();
        //    Console.ReadLine();

        //}

    }
}
