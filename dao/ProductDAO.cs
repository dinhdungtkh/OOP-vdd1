using dao;
using OOP_dung.vd.entity;
using System.Runtime.InteropServices.ComTypes;


namespace OOP_dung.vd.dao
{
    public class ProductDAO : BaseDao<Product> 
    {
        Database db;
        public ProductDAO()
        {
            db = new Database();
        }


        public override void Insert(Product row)
        {
            db.InsertTable(tableName.product, row);
        }

        public override void Update(Product row)
        {
            db.UpdateTable(tableName.product, row);
        }

        public override bool Delete(Product row)
        {
            return db.DeleteTable(tableName.product, row);
        }

        public override List<Product> FindAll() { 
        return db.SelectTable(tableName.product);
        }
        public override Product FindById(int id)
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

        public Product Search(string keyword)
        {
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

