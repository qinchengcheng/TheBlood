using Minke.TheBlood.EFData.Models;
using Minke.TheBlood.Models;
using PL_CoreFrame.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

using Minke.TheBlood.IDal;
using AutoMapper;

namespace Minke.TheBlood.Dal
{
    public class RegionsDal : DAL<SysRegion, TSysRegion>, IRegions
    {
        public RegionsDal(IEfRepository<TSysRegion> eIfRepository, IMapper aIMapper) : base(eIfRepository, aIMapper)
        {

        }
        public List<SysRegion> GetList()
        {
            var it = this.EfRepository.Table<TSysRegion>();
            return new List<SysRegion>();
        }
    }
}
