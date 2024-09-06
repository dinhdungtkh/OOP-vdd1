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
        public override bool Delete(Accessory row)
        {
            return db.DeleteTable(tableName.accessory, row);
        }

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

        public override List<Accessory> FindAll()
        {
            return db.SelectTable(tableName.accessory);
        }

        public override void Insert(Accessory row)
        {
            db.InsertTable(tableName.accessory, row);
        }


        public override void Update(Accessory row)
        {
            db.UpdateTable(tableName.accessory, row);
        }
    }
}
