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
    /// 数据操作基础接口定义
    /// </summary>
    /// <typeparam name="Entity">The type of the ntity.</typeparam>
    /// <seealso cref="PL_Data.IRepositoryBase" />
    /// <author>
    /// Dongd
    /// </author>
    /// <remarks>
    /// 2016/8/9 [Dongd] 创建。
    /// </remarks>
    public interface IRepository<Entity> : IRepositoryBase where Entity : class
    {
        void Create(Entity aEntity);

        void Update(Entity aEntity);

        void MergeUpdate(Entity aEntity);

        void Merge(Entity aEntity);

        void SaveOrUpdate(Entity aEntity);

        void Delete(Entity aEntity);

        void Delete(object aKey);

        void Copy(Entity aSource, Entity aTarget);

        int Count(Expression<Func<Entity, bool>> aPredicate);

        int GetCount(string aPropertyName, object aValue);
        
        Entity Get(object aKey);

        Entity Load(object aKey);

        Entity Get(Expression<Func<Entity, bool>> aPredicate);

        IQueryable<Entity> Table();
        IQueryable<Entity> TableWithCache();
                
        IQueryable<Entity> Fetch(Action<Orderable<Entity>> aOrder);
        IQueryable<Entity> Fetch(Expression<Func<Entity, bool>> aPredicate);
        IQueryable<Entity> Fetch(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder);        

        IQueryable<Entity> FetchWithCache(Action<Orderable<Entity>> aOrder);
        IQueryable<Entity> FetchWithCache(Expression<Func<Entity, bool>> aPredicate);
        IQueryable<Entity> FetchWithCache(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder);

        IQueryable<Entity> Fetch(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder, int aSkip, int aCount);
        IQueryable<Entity> FetchWithCache(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder, int aSkip, int aCount);
    }



}
