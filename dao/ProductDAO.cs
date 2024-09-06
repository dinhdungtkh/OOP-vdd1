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
        public Product FindById(int id)
        {

            var productID = db.SelectTable(tableName.product);

            for (int i = 0; i < productID.Count; i++)
            {
                if (productID[i].id == id)
                {
                    return productID[i];
                }
                else return null;
            }
            return null;

        }
        public Product FindByName(string name) {

            var productID = db.SelectTable(tableName.product);

            for (int i = 0; i < productID.Count; i++)
            {
                if (productID[i].name == name)
                {
                    return productID[i];
                }
                else return null;
            }
            return null;
        }
    }
}

