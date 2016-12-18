using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
/****************
 * 描述：数据库操作接口
 * 作者：mo
 * 创建日期：2015-06-15
 * 修改日期：2015-06-15
 */
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
        bool Create(T entity);
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="listEntity"></param>
        /// <returns></returns>
        bool BatchCreate(List<T> listEntity);
        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="isSave">是否保存到数据库</param>
        /// <returns></returns>
        bool Update(T entity);

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        bool DeleteByEntity(T entity);

        /// <summary>
        /// 根据ID删除实体【主键】
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteByID(int id);

        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> where);

        /// <summary>
        /// 根据ID获取实体【主键】
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetByID(int id);

        /// <summary>
        /// 返回实体集合
        /// </summary>
        /// <returns></returns>
        List<T> GetList();

        /// <summary>
        /// 根据条件返回集合
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IQueryable<T> GetList(Expression<Func<T, bool>> where);

        List<T> GetList<orderByT>(Expression<Func<T, bool>> where, Expression<Func<T, orderByT>> orderBy, bool isAscending);
    }
}
