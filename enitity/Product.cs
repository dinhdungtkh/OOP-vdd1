namespace OOP_dung.vd.enitity
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
   
        public string GetProductInfo()
        {
            return $"{id}: {name} - {categoryId}";
        }



    }
}