using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PL_Core;

namespace PL_CoreFrame.Data.EF
{
    public class RepositoryBase : PL_Core.Disposable, IRepositoryBase
    {
        DbContext _dbCxt; 
        
        protected DbContext DbCxt
        {
            get { return _dbCxt; }
        }
       
         
        public RepositoryBase(DbContext aDbContext)
        {
            this._dbCxt = aDbContext;
        }
        
        public void Create<T>(T aEntity) where T : class
        {
            _dbCxt.Set<T>().Add(aEntity);
        }

        public void Update<T>(T aEntity) where T : class
        {
            _dbCxt.Set<T>().Attach(aEntity);
            _dbCxt.Entry(aEntity).State = EntityState.Modified;//修改State            
        }

        public void MergeUpdate<T>(T aEntity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Merge<T>(T aEntity) where T : class
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate<T>(T aEntity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(object aKey) where T : class
        {
            var entity = Get<T>(aKey);
            if( entity != null )
                _dbCxt.Set<T>().Remove(entity);
        }

        public void Delete<T>(T aEntity) where T : class
        {
            _dbCxt.Set<T>().Remove(aEntity);
        }

        public void Copy<T>(T aSource, T aTarget) where T : class
        {
            throw new NotImplementedException();
        }

        public T Get<T>(Expression<Func<T, bool>> aPredicate) where T : class
        {
            return _dbCxt.Set<T>().Where(aPredicate).FirstOrDefault();
        }

        public T Get<T>(object aKey) where T : class
        {   
            throw new NotImplementedException();
        }

        public T Load<T>(object aKey) where T : class
        {
            throw new NotImplementedException();
        }

        public int Count<T>(Expression<Func<T, bool>> aPredicate) where T : class
        {
            return _dbCxt.Set<T>().Count(aPredicate);
        }

        public int GetCount<T>(string aPropertyName, object aValue) where T : class
        {
            throw new NotImplementedException();
        }
        
        public IQueryable<T> Table<T>() where T : class
        {
            return _dbCxt.Set<T>();
        }

        public IQueryable<T> TableWithCache<T>() where T : class
        {
            throw new NotImplementedException();
        }


        public IQueryable<T> Fetch<T>(Expression<Func<T, bool>> aPredicate) where T : class
        {
            return _dbCxt.Set<T>().Where(aPredicate);    
        }

        public IQueryable<T> Fetch<T>(Action<Orderable<T>> aOrder) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Fetch<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder) where T : class
        {
            throw new NotImplementedException();
        }       


        public IQueryable<T> FetchWithCache<T>(Expression<Func<T, bool>> aPredicate) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FetchWithCache<T>(Action<Orderable<T>> aOrder) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FetchWithCache<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder) where T : class
        {
            throw new NotImplementedException();
        }


        public IQueryable<T> Fetch<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder, int aSkip, int aCount) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FetchWithCache<T>(Expression<Func<T, bool>> aPredicate, Action<Orderable<T>> aOrder, int aSkip, int aCount) where T : class
        {
            throw new NotImplementedException();
        }

        public int Flush()
        {
            return _dbCxt.SaveChanges();
        }

    }
}
