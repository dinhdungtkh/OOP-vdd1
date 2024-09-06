using OOP_dung.vd.dao;
using OOP_dung.vd.entity;

namespace dao
{
    public class CategoryDAO : BaseDao<Category>
    {
        Database db;

        public CategoryDAO()
        {
            db = Database.Instants;
        }
        /// <summary>
        /// Inserts a new Category into the database.
        /// </summary>
        /// <param name="row"></param>
        public override void Insert(Category row)
        {
            db.InsertTable(tableName.category, row);
        }
        /// <summary>
        /// Updates an existing Category in the database.
        /// </summary>
        /// <param name="row"></param>
        public override void Update(Category row) { 
            db.UpdateTable(tableName.category, row);
        }
        /// <summary>
        /// Deletes a Category from the database.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override bool Delete(Category row) {
            return db.DeleteTable(tableName.category, row);
        }
        /// <summary>
        ///  Finds all Categories in the database.
        /// </summary>
        /// <returns></returns>
        public override List<Category> FindAll()
        {
            return db.SelectTable(tableName.category);
        }
        /// <summary>
        /// Finds a Category by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
