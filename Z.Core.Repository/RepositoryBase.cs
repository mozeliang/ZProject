using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Z.Core.Model.Main;
/****************
 * 描述：数据库操作类
 * 作者：mo
 * 创建日期：2015-06-15
 * 修改日期：2015-06-15
 */
namespace Z.Core.Repository
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryBase<T> where T : class
    {
        private ManagementSystemEntities entities;
        public RepositoryBase()
        {
            entities = new ManagementSystemEntities();
        }
        public RepositoryBase(ManagementSystemEntities ec)
        {
            entities = ec;
        }
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="isSave">是否保存到数据库</param>
        /// <returns></returns>
        public bool Create(T entity, bool isSave)
        {
            try
            {
                //entities.Set<T>().Add(entity);
                var entry = entities.Entry<T>(entity);
                entry.State = System.Data.Entity.EntityState.Added;

                if (isSave)
                {
                    Save();
                    entry.State = System.Data.Entity.EntityState.Detached;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="isSave">是否保存到数据库</param>
        /// <returns></returns>
        public bool Update(T entity, bool isSave) {
            try
            {
                var entry=entities.Entry<T>(entity);
                entry.State = System.Data.Entity.EntityState.Modified;
                if (isSave)
                {
                    Save();
                    entry.State = System.Data.Entity.EntityState.Detached;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 保存到数据库
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
           return entities.SaveChanges();
        }
    }
}
