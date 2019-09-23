using Cad.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Common.Interfaces;

namespace Cad.DataAccessLayer.Repositories.Interfaces
{
    public interface IVtbCodeRepository : IGenericDataRepository<VTB_CODE>
    {
        int GetNextKeyId();
    }
}
