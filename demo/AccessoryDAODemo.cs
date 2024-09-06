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

        public void insertTest()
        {
            demoaccessoryDAO.Insert(new Accessory(11, "Accessory 11"));
            demoaccessoryDAO.Insert(new Accessory(12, "Accessory 12"));
            demoaccessoryDAO.Insert(new Accessory(13, "Accessory 13"));
            Console.WriteLine("After Insert:");
            findAllTest();
        }

        public void updateTest()
        {
            demoaccessoryDAO.Update(new Accessory(11, "Accessory Updated 11"));
            Console.WriteLine("After Update:");
            findAllTest();
        }

        public void deleteTest()
        {
            demoaccessoryDAO.Delete(new Accessory(12, "Accessory 13"));

        }

        public List<Accessory> findAllTest()
        {
            var accessory = demoaccessoryDAO.FindAll();
            PrintTableTest(tableName.accessory, accessory);
            return accessory;
        }

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



        public void PrintTableTest(tableName name, dynamic data)
        {
            switch (name)
            {
                case tableName.accessory:
                    List<Accessory> dataAccessory = (List<Accessory>)data;
                    Console.WriteLine("-Accessory-");
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
