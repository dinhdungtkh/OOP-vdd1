using dao;
using OOP_dung.vd.entity;


namespace OOP_dung.vd.dao
{
    public class ProductDAO : BaseDao<Product>
    {
        Database db;
        public ProductDAO()
        {
            db = Database.Instants;
        }

        /// <summary>
        /// Inserts a new Product into the database.
        /// </summary>
        /// <param name="row"></param>
        public override void Insert(Product row)
        {
            db.InsertTable(tableName.product, row);
        }
        /// <summary>
        /// Updates an existing Product in the database.
        /// </summary>
        /// <param name="row"></param>
        public override void Update(Product row)
        {
            db.UpdateTable(tableName.product, row);
        }
        /// <summary>
        /// Deletes a Product from the database.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override bool Delete(Product row)
        {
            return db.DeleteTable(tableName.product, row);
        }
        /// <summary>
        /// Finds all Products in the database
        /// </summary>
        /// <returns></returns>
        public override List<Product> FindAll()
        {
            return db.SelectTable(tableName.product);
        }
        /// <summary>
        /// Finds a Product by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        ///  Searches for a Product by keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public Product Search(string keyword)
        {
            return null;
        }
        /// <summary>
        /// Finds a Product by its name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        public Product FindByName(string name)
        {

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

