using OOP_dung.vd.enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dung.vd.dao
{
    public abstract class BaseDao<T> where T : Base
    {
        public abstract T findById(int id);
        public abstract List<T> findAll();
        public abstract void Insert(T row);
        public abstract void Update(T row);
        public abstract bool Delete(T row);

    }
}
