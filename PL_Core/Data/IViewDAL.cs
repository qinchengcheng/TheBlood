using PL_Core.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_Core.Data
{
    public interface IViewDAL<Mv>
    {
        Mv GetView(object aKey);

        Mv GetView(object aKey, bool aUseCache = false);
        
        List<Mv> GetList(bool aUseCache = false, int? aTopNum = null);        
    }
}
