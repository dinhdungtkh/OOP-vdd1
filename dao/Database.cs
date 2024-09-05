using OOP_dung.vd.enitity;
public enum tableName
{
    product,
    category,
    accessory,
}

namespace dao
{

    public class Database
    {
        // private static List<Product> productTable = new List<Product>();
        public List<Product> productTable = new List<Product>();
        public static List<Category> categoryTable = new List<Category>();
        public List<Accessory> accessoryTable = new List<Accessory>();

        private static Database instance;

        public static Database Instants
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public int InsertTable(string name, object row)
        {
            switch (name)
            {
                case "product":
                    productTable.Add(row as Product);
                    return productTable.Count;
                case "category":
                    categoryTable.Add(row as Category);
                    return categoryTable.Count;
                case "accessory":
                    accessoryTable.Add(row as Accessory);
                    return accessoryTable.Count;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }

        public dynamic SelectTable(string name)
        {
            switch (name)
            {
                case "product":
                    return productTable;
                case "category":
                    return categoryTable;
                case "accessory":
                    return accessoryTable;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }

        public void UpdateTable(string name, object row)
        {
            switch (name)
            {
                case "product":
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
                case "category":
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
                case "accessory":
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

        public bool DeleteTable(string name, object row)
        {
            switch (name)
            {
                case "product":
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
                case "category":
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
                case "accessory":
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


        public void UpdateTableById(int id, object row)
        {
            switch (id)
            {

                default: throw new ArgumentException("Invalid table name");
            }
        }

        public void TruncateTable(string name)
        {
            switch (name.ToLower())
            {
                case "product":
                    productTable.Clear();
                    break;
                case "category":
                    categoryTable.Clear();
                    break;
                case "accessory":
                    accessoryTable.Clear();
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }
    }
}