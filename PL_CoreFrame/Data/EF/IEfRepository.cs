using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PL_CoreFrame.Data.EF
{
    public interface IEfRepository<Entity> : IRepository<Entity> where Entity : class
    {
        DbContext CurrentDbContext { get; }
       
        
        Task<int> FlushAsync();
    }
}
