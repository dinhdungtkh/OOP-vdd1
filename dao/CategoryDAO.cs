using OOP_dung.vd.dao;
using OOP_dung.vd.entity;

namespace dao
{
    public class CategoryDAO : BaseDao<Category>
    {
        Database db;

        public CategoryDAO()
        {
            db = new Database();
        }
        public override void Insert(Category row)
        {
            db.InsertTable(tableName.category, row);
        }

        public override void Update(Category row) { 
            db.UpdateTable(tableName.category, row);
        }
        public override bool Delete(Category row) {
            return db.DeleteTable(tableName.category, row);
        }
        public override List<Category> FindAll()
        {
            return db.SelectTable(tableName.category);
        }

        public override Category FindById(int id)
        {
            var categoryID = db.SelectTable(tableName.category);

            for (int i = 0; i < categoryID.Count; i++)
            {
                if (categoryID[i].id == id)
                {
                    return categoryID[i];
                }
                else return null;
            }
            return null;
        }
    }
}
