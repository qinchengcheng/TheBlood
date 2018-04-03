using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PL_Core
{
    /// <summary>
    /// 集合排序扩展
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <author>
    /// Dongd
    /// </author>
    /// <remarks>
    /// 2016/8/9 [Dongd] 创建。
    /// </remarks>
    public class Orderable<T>
    {
        private IQueryable<T> _queryable;

        public Orderable(IQueryable<T> enumerable)
        {
            _queryable = enumerable;
        }

        public IQueryable<T> Queryable
        {
            get { return _queryable; }
        }

        public Orderable<T> Asc<TKey>(Expression<Func<T, TKey>> aKeySelector)
        {
            _queryable = _queryable
                .OrderBy(aKeySelector);
            return this;
        }

        public Orderable<T> Asc<TKey1, TKey2>(Expression<Func<T, TKey1>> aKeySelector1,
                                              Expression<Func<T, TKey2>> aKeySelector2)
        {
            _queryable = _queryable
                .OrderBy(aKeySelector1)
                .OrderBy(aKeySelector2);
            return this;
        }

        public Orderable<T> Asc<TKey1, TKey2, TKey3>(Expression<Func<T, TKey1>> aKeySelector1,
                                                     Expression<Func<T, TKey2>> aKeySelector2,
                                                     Expression<Func<T, TKey3>> aKeySelector3)
        {
            _queryable = _queryable
                .OrderBy(aKeySelector1)
                .OrderBy(aKeySelector2)
                .OrderBy(aKeySelector3);
            return this;
        }

        public Orderable<T> Desc<TKey>(Expression<Func<T, TKey>> aKeySelector)
        {
            _queryable = _queryable
                .OrderByDescending(aKeySelector);
            return this;
        }

        public Orderable<T> Desc<TKey1, TKey2>(Expression<Func<T, TKey1>> aKeySelector1,
                                               Expression<Func<T, TKey2>> aKeySelector2)
        {
            _queryable = _queryable
                .OrderByDescending(aKeySelector1)
                .OrderByDescending(aKeySelector2);
            return this;
        }

        public Orderable<T> Desc<TKey1, TKey2, TKey3>(Expression<Func<T, TKey1>> aKeySelector1,
                                                      Expression<Func<T, TKey2>> aKeySelector2,
                                                      Expression<Func<T, TKey3>> aKeySelector3)
        {
            _queryable = _queryable
                .OrderByDescending(aKeySelector1)
                .OrderByDescending(aKeySelector2)
                .OrderByDescending(aKeySelector3);
            return this;
        }
    }



}
