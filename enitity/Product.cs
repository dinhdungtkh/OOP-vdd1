using System;

public class Product {
  public int id;
  public string name;
  public int categoryId;

  public Product(int ID, string Name, int CategoryID)
    {
        id = ID;
        name = Name;
        categoryId = CategoryID;
    }

  public void setId(int id) {
     this.id = id;
  }

  public int getId(){
    return id;
  }

  public string GetProductInfo() {
        return $"{id}: {name} - {categoryId}"; 
    } 
    

}