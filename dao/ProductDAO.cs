using dao;
using OOP_dung.vd.enitity;

namespace OOP_dung.vd.dao
{
    public class ProductDAO
    {
        Database db;
        public ProductDAO()
        {
            db = new Database();
        }


        public void Insert(object row)
        {
            db.InsertTable(tableName.product, (Product)row);
        }

        public void Update(object row)
        {
            db.UpdateTable(tableName.product, (Product)row);
        }

        public bool Delete(object row)
        {
            return db.DeleteTable(tableName.product, row);
        }

        public List<Product> findAll() { 
        return db.SelectTable(tableName.product);
        }
        public List<Product> FindById(int id)

        {

            return db.SelectTable(tableName.product);
            
        }
        public void FindByName(string name) { }
    }
}

