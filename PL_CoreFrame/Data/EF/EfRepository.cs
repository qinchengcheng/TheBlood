using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using PL_Core.Collections;
using Microsoft.EntityFrameworkCore;

namespace PL_CoreFrame.Data.EF
{
    public class EfRepository<Entity> : Repository<Entity>, IEfRepository<Entity>
     where Entity : class
    {
        public EfRepository(DbContext aDbContext) : base(aDbContext)
        {

        }

        public DbContext CurrentDbContext
        {
            get
            {
                return DbCxt;
            }
        }

          
        /// <summary>
        /// 异步提交
        /// </summary>
        /// <returns>
        /// 返回 <seealso cref="Task{System.Int32}"/>。
        /// </returns>
        /// <author>
        /// Dongde
        /// </author>
        /// <remarks>
        /// 2016/9/26 [Dongde] 创建。
        /// </remarks>
        public async Task<int> FlushAsync()
        {
            return await CurrentDbContext.SaveChangesAsync();
        }
    }


}
