using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_Core.Data
{
    public interface IDAL<Mo>
    {
        void Create(Mo aModel, ref string aResultMessage);

        void Update(Mo aModel, ref string aResultMessage);

        void SaveOrUpdate(Mo aModel, ref string aResultMessage);

        void Delete(object aKey, ref string aResultMessage);

        Mo Get(object aKey);

        void Cancel();
        void Commit();
    }

}
