using OOP_dung.vd.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dung.vd.dao
{
    public abstract class BaseDao<T> where T : Base
    {
        public abstract T FindById(int id);
        public abstract List<T> FindAll();
        public abstract void Insert(T row);
        public abstract void Update(T row);
        public abstract bool Delete(T row);

    }
}
