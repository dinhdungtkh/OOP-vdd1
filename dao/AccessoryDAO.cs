using dao;
using OOP_dung.vd.entity;

namespace OOP_dung.vd.dao
{
    public class AccessoryDAO : BaseDao<Accessory>
    {
        Database db;

        public AccessoryDAO()
        {
            db = Database.Instants;
        }
        /// <summary>
        /// Deletes an Accessory from the database.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override bool Delete(Accessory row)
        {
            return db.DeleteTable(tableName.accessory, row);
        }

        /// <summary>
        /// Finds an Accessory by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Accessory FindById(int id)
        {
            var accessoryID = db.SelectTable(tableName.accessory);

            for (int i = 0; i < accessoryID.Count; i++)
            {
                if (accessoryID[i].id == id)
                {
                    return accessoryID[i];
                }
                else return null;
            }
            return null;
        }
        /// <summary>
        /// Finds all Accessories in the database.
        /// </summary>
        /// <returns></returns>
        public override List<Accessory> FindAll()
        {
            return db.SelectTable(tableName.accessory);
        }
        /// <summary>
        /// Inserts a new Accessory into the database.
        /// </summary>
        /// <param name="row"></param>
        public override void Insert(Accessory row)
        {
            db.InsertTable(tableName.accessory, row);
        }

        /// <summary>
        /// Updates an existing Accessory in the database.
        /// </summary>
        /// <param name="row"></param>
        public override void Update(Accessory row)
        {
            db.UpdateTable(tableName.accessory, row);
        }
    }
}
