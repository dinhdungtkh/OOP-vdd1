using System;


public class Product {
  public int id;
  public string name;
  public int categoryId;

    public Product(int ID, string Name)
    {
        id = ID;
        name = Name;
    }
    public Product(int ID, string Name, int CategoryID)
    {
        id = ID;
        name = Name;
        categoryId = CategoryID;
    }

  public void setId(int _id) {
     this.id = _id;
  }

  public int getId(){
    return id;
  }

  public string GetProductInfo() {
        return $"{id}: {name} - {categoryId}"; 
    } 
  
  

}