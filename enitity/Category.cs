using System;


public class Category
{
	public int id;
	public string name;
    
	public Category() {
		id = 1;
		name = "Category";
	}
    public Category(int _id, string _name)	 
    {
		id = _id ;
		name = _name;
    }

    public int getId(){
		return id;
	}
	public void setId(int _id){
		id = _id;
	}

}