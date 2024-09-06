using System;

namespace OOP_dung.vd.entity
{
    public class Category : Base 
    {

        public Category()
        {
            id = 1;
            name = "Category";
        }
        public Category(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

        public string GetCategoryInfo()
        {
            return $"{id}: {name}";
        }
    }
}