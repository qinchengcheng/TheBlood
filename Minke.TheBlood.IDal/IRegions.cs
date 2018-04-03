using Minke.TheBlood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minke.TheBlood.IDal
{
    public interface IRegions
    {
        List<SysRegion> GetList();
    }
}
