namespace dao

{

    using OOP_dung.vd.entity;

    public enum tableName
    {
        product,
        category,
        accessory,
    }
    sealed class Database
    {

        public List<Product> productTable = new List<Product>();
        public List<Category> categoryTable = new List<Category>();
        public List<Accessory> accessoryTable = new List<Accessory>();

        private static Database instance = null; 



        private static readonly object _lock = new object(); 
        public static Database Instants
        {
            get
            {
                if (instance == null)
                {
                    lock(_lock)
                    {
                        if (instance == null) 
                        { instance = new Database(); }
                    }
                  
                }
                return instance;
            }
        }
        /// <summary>
        /// Inserts a new row into the specified table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns>The new count of rows in the table after insertion.</returns>
        /// <exception cref="ArgumentException"></exception>
        public int InsertTable(tableName name, object row)
        {

            switch (name)
            {
                case tableName.product:
                    productTable.Add(row as Product);
                    return productTable.Count;
                case tableName.category:
                    categoryTable.Add(row as Category);
                    return categoryTable.Count;
                case tableName.accessory:
                    accessoryTable.Add(row as Accessory);
                    return accessoryTable.Count;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }
        /// <summary>
        /// Selects all rows from the specified table.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>A list of rows from the specified table.</returns>
        /// <exception cref="ArgumentException"></exception>
        public dynamic SelectTable(tableName name)
        {
            switch (name)
            {
                case tableName.product:
                    return productTable;
                case tableName.category:
                    return categoryTable;
                case tableName.accessory:
                    return accessoryTable;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }
        /// <summary>
        /// Updates an existing row in the specified table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdateTable(tableName name, object row)
        {
            switch (name)
            {
                case tableName.product:
                    Product updatedProduct = (Product)row;
                    if (updatedProduct != null)
                    {
                        for (int i = 0; i < productTable.Count; i++)
                        {
                            if (productTable[i].id == updatedProduct.id)
                            {
                                productTable[i] = updatedProduct;
                                return;
                            }
                        }
                    }
                    throw new ArgumentException("Invalid product name");
                case tableName.category:
                    Category updatedCategory = (Category)row;
                    if (updatedCategory != null)
                    {
                        for (int i = 0; i < categoryTable.Count; i++)
                        {
                            if (categoryTable[i].id == updatedCategory.id)
                            {
                                categoryTable[i] = updatedCategory;
                                return;
                            }
                        }
                    }
                    throw new ArgumentException("Invalid Category name");
                case tableName.accessory:
                    Accessory updatedAccessory = (Accessory)row;
                    if (updatedAccessory != null)
                    {
                        for (int i = 0; i < accessoryTable.Count; i++)
                        {
                            if (accessoryTable[i].id == updatedAccessory.id)
                            {
                                accessoryTable[i] = updatedAccessory;
                                return;
                            }
                        }
                    }
                    throw new ArgumentException("Invalid Category name");
                default: throw new ArgumentException("Invalid table name");
            }
        }
        /// <summary>
        /// Deletes a row from the specified table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns>True if the row was deleted /  false if it was not found.</returns>
        public bool DeleteTable(tableName name, object row)
        {
            switch (name)
            {
                case tableName.product:
                    Product productToRemove = (Product)row;
                    if (productToRemove != null)
                    {
                        for (int i = 0; i < productTable.Count; i++)
                        {
                            if (productTable[i].id == productToRemove.id)
                            {
                                productTable.RemoveAt(i);
                                return true;
                            }
                        }

                    }
                    return false;
                case tableName.category:
                    Category categoryToRemove = (Category)row;
                    if (categoryToRemove != null)
                    {
                        for (int i = 0; i < categoryTable.Count; i++)
                        {
                            if (categoryTable[i].id == categoryToRemove.id)
                            {
                                categoryTable.RemoveAt(i);
                                return true;
                            }
                        }

                    }
                    return false;
                case tableName.accessory:
                    Accessory accessoryToRemove = (Accessory)row;
                    if (accessoryToRemove != null)
                    {
                        for (int i = 0; i < accessoryTable.Count; i++)
                        {
                            if (accessoryTable[i].id == accessoryToRemove.id)
                            {
                                accessoryTable.RemoveAt(i);
                                return true;
                            }
                        }

                    }
                    return false;
                default:
                    return false;
            }

        }

        /// <summary>
        /// Updates a row by its ID in the specified table.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        public void UpdateTableById(int id, object row)
        {

            if (row is Product)
            {
                Product updatedProduct = (Product)row;
                for (int i = 0; i < productTable.Count; i++)
                {
                    if (productTable[i].id == id)
                    {
                        productTable[i] = updatedProduct;
                        return;
                    }
                }
            }
            else if (row is Category)
            {
                Category category = (Category)row;
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    if (categoryTable[i].id == id)
                    {
                        categoryTable[i] = category;
                        return;
                    }
                }
            }
            else if (row is Accessory)
            {
                Accessory accessory = (Accessory)row;
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    if (accessoryTable[i].id == id)
                    {
                        accessoryTable[i] = accessory;
                        return;
                    }
                }
            }


        }
        /// <summary>
        /// Clears all rows from the specified table
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"></exception>
        public void TruncateTable(tableName name)
        {
            switch (name)
            {
                case tableName.product:
                    productTable.Clear();
                    break;
                case tableName.category:
                    categoryTable.Clear();
                    break;
                case tableName.accessory:
                    accessoryTable.Clear();
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }
    }
}