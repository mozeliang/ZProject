using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public virtual bool Create(T entity)
        {
            try
            {
                //entities.Set<T>().Add(entity);
                var entry = entities.Entry<T>(entity);
                entry.State = System.Data.Entity.EntityState.Added;
                entities.SaveChanges();
                entry.State = System.Data.Entity.EntityState.Detached;

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
        public virtual bool Update(T entity)
        {
            try
            {
                var entry = entities.Entry<T>(entity);
                entry.State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                entry.State = System.Data.Entity.EntityState.Detached;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool DeleteByEntity(T entity)
        {
            try
            {
                var entry = entities.Entry<T>(entity);
                entry.State = System.Data.Entity.EntityState.Deleted;
                entities.SaveChanges();
                entry.State = System.Data.Entity.EntityState.Detached;

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 根据ID删除实体【主键】
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool DeleteByID(int id)
        {
            try
            {
                var entity = GetByID(id);
                if (entity == null)
                    return false;
                else
                    DeleteByEntity(entity);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public virtual T Get(Expression<Func<T, bool>> where)
        {
            try
            {
                return entities.Set<T>().Where(where).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据ID获取实体【主键】
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetByID(int id)
        {
            try
            {
                return entities.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 返回实体集合
        /// </summary>
        public virtual List<T> GetList()
        {
            try
            {
                return entities.Set<T>().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 根据条件返回集合
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetList(Expression<Func<T, bool>> where)
        {
            try
            {
                return entities.Set<T>().Where(where);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual List<T> GetList(Expression<Func<T, bool>> where, Expression<Func<T,object>> orderBy, bool isAscending)
        {
            try
            {
                var list = entities.Set<T>().Where(where);
                if (isAscending)
                {
                    list = list.OrderBy(orderBy);
                }
                else
                {
                    list = list.OrderByDescending(orderBy);
                }

                return list.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
