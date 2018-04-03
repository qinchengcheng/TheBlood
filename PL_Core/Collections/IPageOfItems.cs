using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_Core.Collections
{
    /// <summary>
    /// 分页集合接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
    /// <author>
    /// Dongde
    /// </author>
    /// <remarks>
    /// 2016/10/17 [Dongde] 创建。
    /// </remarks>
    public interface IPageOfItems<out T> : IEnumerable<T>
    {
        int PageNumber { get; }
        int PageSize { get; }
        int TotalItemCount { get; }
        int Pages { get; }
        int StartPosition { get; }
        int EndPosition { get; }
    }
}
