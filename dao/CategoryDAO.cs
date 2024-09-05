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
            db.InsertTable("category", row);
        }

        public void Update(object row) { db.UpdateTable("category", row); }
        public bool Delete(object row) { return db.DeleteTable("category", row); }
        public  List<Category> FindAll()
        {
            return db.SelectTable("Category");
        }

        public dynamic findById(string name)
        {
            throw new ArgumentException("Invalid ID");
        }
    }
}
