using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_Core.Collections
{
    /// <summary>
    /// 分页集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.List{T}" />
    /// <seealso cref="PL_CoreFrame.Collections.IPageOfItems{T}" />
    /// <author>
    /// Dongde
    /// </author>
    /// <remarks>
    /// 2016/10/17 [Dongde] 创建。
    /// </remarks>
    public class PageOfItems<T> : List<T>, IPageOfItems<T>
    {
        /// <summary>
        /// 当前分页
        /// </summary>
        public int PageNumber { get; private set; }
        /// <summary>
        /// 显示数据条目
        /// </summary>
        public int PageSize { get; private set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalItemCount { get; private set; }
        /// <summary>
        ///  总页数
        /// </summary>
        /// <author>
        /// Dongde
        /// </author>
        /// <remarks>
        /// 2016/10/17 [Dongde] 创建。
        /// </remarks>
        public int Pages { get;private set; }

        public int StartPosition
        {
            get { return (PageNumber - 1) * PageSize + 1; }
        }

        public int EndPosition
        {
            get { return PageNumber * PageSize > TotalItemCount ? TotalItemCount : PageNumber * PageSize; }
        }

        public PageOfItems(IEnumerable<T> aSource, int aPageNumber, int aPageSize, int aTotalItemCount)
        {
            PageNumber = aPageNumber;
            PageSize = aPageSize;
            TotalItemCount = aTotalItemCount;
            Pages = (int)Math.Ceiling((double)TotalItemCount / PageSize);
            AddRange(aSource);
        }

        public PageOfItems(IEnumerable<T> aSource, int aPageNumber, int aPageSize, int aTotalItemCount, int aPages)
        {
            PageNumber = aPageNumber;
            PageSize = aPageSize;
            TotalItemCount = aTotalItemCount;
            Pages = aPages;
            AddRange(aSource);
        }
       
    }



}
