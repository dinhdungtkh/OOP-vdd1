using System;

public class Accessory
{
	public int id;
	public string name; 

	public Accessory ( int _id, string _name ) {
		id = _id;
		name = _name;
	}

   public int getId() { return id; }
   public void  setId(int _id) { id = _id; }


}