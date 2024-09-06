using System;
namespace OOP_dung.vd.entity
{
    public class Accessory : Base 
    {
        public Accessory(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        public string GetAccessoryInfo()
        {
            return $"{id}: {name}";
        }

    }
}