using Cad.DataAccessLayer.Context;
using Cad.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Data.Entity.Core.Objects;

namespace Cad.DataAccessLayer.Repositories
{
    class VtbCodeRepository : GenericDataRepository<VTB_CODE>, IVtbCodeRepository
    {
        private CadEntities _context;
        public VtbCodeRepository(CadEntities context)
            :base(context)
        {
            _context = context;
        }

        public int GetNextKeyId()
        {
            ObjectParameter param = new ObjectParameter("RetVal", typeof(Int32));
            _context.SP_GETNEXTKEYID_VTBCODEINSERT("VTB_CODE", param);
            return Convert.ToInt32(param.Value);
        }       
    }
}
