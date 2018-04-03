using System;
using System.Collections.Generic;

namespace Minke.TheBlood.Models
{
    public class BloodStock
    {
        public long BloodStockId { get; set; }
        public Guid RegionId { get; set; }
        public string BloodType { get; set; }
        public decimal Inventory { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
