using System;
using System.Collections.Generic;

namespace Minke.TheBlood.Models
{
    public  class SysRegion
    {
        public Guid RegionId { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionSimpleName { get; set; }
        public string RegionFullName { get; set; }
        public string RegionLayerCode { get; set; }
        public string RegionLayerLevel { get; set; }
        public int RegionDeleted { get; set; }
        public string ExMapDraw { get; set; }
    }
}
