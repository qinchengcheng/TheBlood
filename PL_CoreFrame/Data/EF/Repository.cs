using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PL_Core;
using Microsoft.EntityFrameworkCore;

namespace PL_CoreFrame.Data.EF
{
    public class Repository<Entity> : RepositoryBase, IRepository<Entity>
                                      where Entity : class
    {
        public Repository(DbContext aDbContext) : base(aDbContext)
        {
        }

        void IRepository<Entity>.Create(Entity aEntity)
        {
            base.Create<Entity>(aEntity);
        }

        void IRepository<Entity>.Update(Entity aEntity)
        {
            base.Update<Entity>(aEntity);
        }

        void IRepository<Entity>.MergeUpdate(Entity aEntity)
        {
            base.MergeUpdate<Entity>(aEntity);
        }

        void IRepository<Entity>.Merge(Entity aEntity)
        {
            base.Merge<Entity>(aEntity);
        }

        void IRepository<Entity>.SaveOrUpdate(Entity aEntity)
        {
            base.SaveOrUpdate<Entity>(aEntity);
        }

        void IRepository<Entity>.Delete(Entity aEntity)
        {
            base.Delete<Entity>(aEntity);
        }

        void IRepository<Entity>.Delete(object aKey)
        {
            base.Delete<Entity>(aKey);
        }

        void IRepository<Entity>.Copy(Entity aSource, Entity aTarget)
        {
            base.Copy<Entity>(aSource, aTarget);
        }

        int IRepository<Entity>.Count(Expression<Func<Entity, bool>> aPredicate)
        {
            return base.Count<Entity>(aPredicate);
        }

        int IRepository<Entity>.GetCount(string aPropertyName, object aValue)
        {
            return base.GetCount<Entity>(aPropertyName, aValue);
        }

        Entity IRepository<Entity>.Get(object aKey)
        {
            return base.Get<Entity>(aKey);
        }

        Entity IRepository<Entity>.Load(object aKey)
        {
            return base.Load<Entity>(aKey);
        }

        Entity IRepository<Entity>.Get(Expression<Func<Entity, bool>> aPredicate)
        {
            return base.Get<Entity>(aPredicate);
        }

        IQueryable<Entity> IRepository<Entity>.Table()
        {
            return base.Table<Entity>();
        }

        IQueryable<Entity> IRepository<Entity>.TableWithCache()
        {
            return base.TableWithCache<Entity>();
        }


        IQueryable<Entity> IRepository<Entity>.Fetch(Action<Orderable<Entity>> aOrder)
        {
            return base.Fetch<Entity>(aOrder);
        }

        IQueryable<Entity> IRepository<Entity>.Fetch(Expression<Func<Entity, bool>> aPredicate)
        {
            return base.Fetch<Entity>(aPredicate);
        }

        IQueryable<Entity> IRepository<Entity>.Fetch(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder)
        {
            return base.Fetch<Entity>(aPredicate, aOrder);
        }
        
        
        IQueryable<Entity> IRepository<Entity>.FetchWithCache(Action<Orderable<Entity>> aOrder)
        {
            return base.FetchWithCache<Entity>(aOrder);
        }

        IQueryable<Entity> IRepository<Entity>.FetchWithCache(Expression<Func<Entity, bool>> aPredicate)
        {
            return base.FetchWithCache<Entity>(aPredicate);
        }

        IQueryable<Entity> IRepository<Entity>.FetchWithCache(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder)
        {
            return base.FetchWithCache<Entity>(aPredicate, aOrder);

        }


        IQueryable<Entity> IRepository<Entity>.Fetch(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder, int aSkip, int aCount)
        {
            return base.Fetch<Entity>(aPredicate, aOrder, aSkip, aCount);
        }

        IQueryable<Entity> IRepository<Entity>.FetchWithCache(Expression<Func<Entity, bool>> aPredicate, Action<Orderable<Entity>> aOrder, int aSkip, int aCount)
        {
            return base.FetchWithCache<Entity>(aPredicate, aOrder, aSkip, aCount);
        }



    }
}
