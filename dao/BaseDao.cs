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
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract T FindById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract List<T> FindAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        public abstract void Insert(T row);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        public abstract void Update(T row);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public abstract bool Delete(T row);

    }
}
