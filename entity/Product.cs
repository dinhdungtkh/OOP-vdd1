namespace OOP_dung.vd.entity
{
  public class Product : Base
    {
        public int categoryId {  get; set; }

        public Product(int ID, string Name, int CategoryID)
        {
            id = ID;
            name = Name;
            categoryId = CategoryID;
        }
         
        public Product(int ID, string Name)
        {
            id = ID;
            name = Name;
        }

        public Product(int ID)
        {
            id = ID;
        }
        public string GetProductInfo()
        {
            return $"{id}: {name} - {categoryId}";
        }



    }
}