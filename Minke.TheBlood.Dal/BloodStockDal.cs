using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Minke.TheBlood.EFData.Models;
using Minke.TheBlood.IDal;
using Minke.TheBlood.Models;
using PL_CoreFrame.Data.EF;

namespace Minke.TheBlood.Dal
{
    public class BloodStockDal : DAL<BloodStock, TBloodStock>, IBloodStock
    {
        public BloodStockDal(IEfRepository<TBloodStock> eIfRepository, IMapper aIMapper) : base(eIfRepository, aIMapper)
        {
           
        }
        public List<BloodStock> GetList()
        {
            var it = this.EfRepository.Table<TBloodStock>();
            return new List<BloodStock>();
        }
    }
}
