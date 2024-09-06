using OOP_dung.vd.enitity;
using System.Collections.Immutable;

namespace dao
{
    public class CategoryDAO
    {
        Database db;

        public CategoryDAO()
        {
            db = new Database();
        }
        public void Insert(object row)
        {
            db.InsertTable(tableName.category, row);
        }

        public void Update(object row) { db.UpdateTable(tableName.category, row); }
        public bool Delete(object row) { return db.DeleteTable(tableName.category, row); }
        public List<Category> FindAll()
        {
            return db.SelectTable(tableName.category);
        }

        public Category findById(int id)  
        {
            var categoryID =  db.SelectTable(tableName.category);

            for (int i = 0; i < categoryID.Count; i++) {
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
