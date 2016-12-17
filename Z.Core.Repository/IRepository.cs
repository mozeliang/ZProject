using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Core.Repository
{
    public interface IRepository<T> where T:class
    {
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="isSava">是否保存到数据库</param>
        /// <returns></returns>
        bool Create(T entity, bool isSave=true);

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="isSave">是否保存到数据库</param>
        /// <returns></returns>
        bool Update(T entity, bool isSave = true);

        /// <summary>
        /// 保存到数据库
        /// </summary>
        /// <returns></returns>
        int Save();
    }
}
