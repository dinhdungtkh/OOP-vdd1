using System;
using System.Collections.Generic;
using System.Linq;

namespace dao
{
    public class Database
    {
        private static List<Product> productTable = new List<Product>();
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
                case "product" :
                     productTable.Add(row as Product);
                       return productTable.Count-1; 
                case "category" :
                       categoryTable.Add(row as Category); 
                       return categoryTable.Count-1;
                case "accessory" :
                    accessoryTable.Add(row as Accessory);
                    return accessoryTable.Count-1;   
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