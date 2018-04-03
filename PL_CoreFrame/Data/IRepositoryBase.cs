using PL_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PL_CoreFrame.Data
{
    /// <summary>
    /// 数据操作基础接口定义。
    /// </summary>
    /// <author>
    /// Dongd
    /// </author>
    /// <remarks>
    /// 2016/7/29 [Dongd] 创建。
    /// </remarks>
    public interface IRepositoryBase
    {
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aEntity">a entity.</param>
        void Create<T>(T aEntity) where T : class;

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aEntity">a entity.</param>
        void Update<T>(T aEntity) where T : class;

        /// <summary>
        /// 合并实体并更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aEntity">a entity.</param>
        void MergeUpdate<T>(T aEntity) where T : class;

        /// <summary>
        /// 实体合并
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aEntity">a entity.</param>
        void Merge<T>(T aEntity) where T : class;

        /// <summary>
        /// 不存在就创建，否则更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aEntity">a entity.</param>
        /// <author>
        /// Dongd
        /// </author>
        /// <remarks>
        /// 2016/7/29 [Dongd] 创建。
        /// </remarks>
        void SaveOrUpdate<T>(T aEntity) where T : class;

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aEntity">a entity.</param>
        void Delete<T>(T aEntity) where T : class;

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aKey">a key.</param>
        void Delete<T>(object aKey) where T : class;

        /// <summary>
        /// 拷贝一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aSource">a source.</param>
        /// <param name="aTarget">a target.</param>
        void Copy<T>(T aSource, T aTarget) where T : class;

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aPredicate">a predicate.</param>
        /// <returns></returns>
        int Count<T>(Expression<Func<T, bool>> aPredicate) where T : class;

        /// <summary>
        /// 查询记录数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aPropertyName">属性名称</param>
        /// <param name="aValue">属性值</param>
        /// <returns>
        /// 返回 <seealso cref="Int32"/>。
        /// </returns>
        /// <author>
        /// Dongd
        /// </author>
        /// <remarks>
        /// 2016/7/29 [Dongd] 创建。
        /// </remarks>
        int GetCount<T>(string aPropertyName, object aValue) where T : class;

        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aKey">a key.</param>
        /// <returns></returns>
        T Get<T>(object aKey) where T : class;

        /// <summary>
        ///获取一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aPredicate">where条件表达式.</param>
        /// <returns></returns>
        T Get<T>(Expression<Func<T, bool>> aPredicate) where T : class;

        /// <summary>
        /// 查询全部实体的准备
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>返回可执行查询的查询语法定义</returns>
        IQueryable<T> Table<T>() where T : class;
        IQueryable<T> TableWithCache<T>() where T : class;
   
        IQueryable<T> Fetch<T>(Action<Orderable<T>> aOrder) where T : class;
        IQueryable<T> Fetch<T>(Expression<Func<T, bool>> aPredicate) where T : class;
        IQueryable<T> Fetch<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder) where T : class;        
        IQueryable<T> FetchWithCache<T>(Action<Orderable<T>> aOrder) where T : class;
        IQueryable<T> FetchWithCache<T>(Expression<Func<T, bool>> aPredicate) where T : class;
        IQueryable<T> FetchWithCache<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder) where T : class;

        IQueryable<T> Fetch<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder, int aSkip, int aCount) where T : class;
        IQueryable<T> FetchWithCache<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder, int aSkip, int aCount) where T : class;

        /// <summary>
        /// 提交数据操作
        /// </summary>
        int Flush();
    }



}
