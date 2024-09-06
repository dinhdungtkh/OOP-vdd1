using OOP_dung.vd.enitity;

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

        public dynamic findById(string name)
        {
            throw new ArgumentException("Invalid ID");
        }
    }
}
