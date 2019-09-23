using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cad.DataAccessLayer.Context;
using WM.Common.Interfaces;
using System.Data;
using Cad.DataAccessLayer.Repositories.Interfaces;

namespace Cad.DataAccessLayer.Repositories
{
    public class DatabaseUnavailable : Exception
    {
        public DatabaseUnavailable(string message) : base(message)
        {

        }
    }
    public class UnitOfWork
    {
        private CadEntities _context = new CadEntities();
        private bool disposed = false;
        private IGenericDataRepository<ISR> isrRepo;
        private IGenericDataRepository<FILE_ATTACHMENT> fileAttachmentRepo;
        private IGenericDataRepository<FILE_DEFINITION> fileDefinitionRepo;
        private IGenericDataRepository<SERVICE_CODE> serviceCodeRepo;
        private IGenericDataRepository<C02_ISR_DISPOS> c02IsrDisposRepo;
        private IGenericDataRepository<C05_ISR_COMM_HEAD> c05IsrCommHeadRepo;
        private IGenericDataRepository<C06_ISR_COMMENT> c06IsrCommentRepo;
        private IGenericDataRepository<ISR_UDF> isrUdfRepo;
        private IGenericDataRepository<SCREEN2_HEADER> screen2HeaderRepo;
        private IGenericDataRepository<UDF_CONTAINER> udfContainerRepo;
        private IGenericDataRepository<UDF_CONTAINER_NODE> udfContainerNodeRepo;
        private IGenericDataRepository<UDF_NODE_SCREEN_RELATION> udfNodeScreenRelationRepo;
        private IVtbCodeRepository vtbCodeRepo;
        private IGenericDataRepository<S05_SCHED_EXCEPT> schedExceptRepo;
        private IGenericDataRepository<PERSONNEL> personnelRepo;
        private IGenericDataRepository<S04_SCHED_PERS> schedPersRepo;
        private IGenericDataRepository<D11_UNIT_ACTIVITY> unitActivityRepo;
        private IGenericDataRepository<D16_MEMB_ACTIVITY> memberActivityRepo;
        private IGenericDataRepository<S02_SHIFT_DETAIL> s02ShiftDetailRepo;
        private IGenericDataRepository<DP_UNIT> dpUnitRepo;
        private IGenericDataRepository<EQUIPMENT> equipmentRepo;
        private IGenericDataRepository<C03_ASSIGN> assignRepo;
        private IGenericDataRepository<ALL_TAB_COLS> allTabsColsRepo;
        private IGenericDataRepository<PERSONNEL_SKILL> personnelSkillRepo;
        private IGenericDataRepository<CAD_PARAMETERS> cadParametersRepo;
        private IGenericSqlDataRepository _genericSqlRepo;

        public UnitOfWork(CadEntities context)
        {
            _context = context;

            if (!_context.Database.Exists())
            {
                throw new DatabaseUnavailable("Database is unavailable");
            }
        }

        public IGenericSqlDataRepository GenericSqlRepo
        {
            get
            {
                if (_genericSqlRepo == null)
                {
                    _genericSqlRepo = new GenericSqlDataRepository(_context);
                }
                return _genericSqlRepo;
            }
        }

        public IGenericDataRepository<PERSONNEL> PersonnelRepo
        {
            get
            {
                if (this.personnelRepo == null)
                {
                    this.personnelRepo = new GenericDataRepository<PERSONNEL>(_context);
                }
                return personnelRepo;
            }
        }

        public IGenericDataRepository<S04_SCHED_PERS> SchedPersRepo
        {
            get
            {
                if (this.schedPersRepo == null)
                {
                    this.schedPersRepo = new GenericDataRepository<S04_SCHED_PERS>(_context);
                }
                return schedPersRepo;
            }
        }

        public IGenericDataRepository<ISR> IsrRepo
        {
            get
            {
                if (this.isrRepo == null)
                {
                    this.isrRepo = new GenericDataRepository<ISR>(_context);
                }
                return isrRepo;
            }
        }

        public IGenericDataRepository<S05_SCHED_EXCEPT> SchdExceptRepo
        {
            get
            {
                if (this.schedExceptRepo == null)
                {
                    this.schedExceptRepo = new GenericDataRepository<S05_SCHED_EXCEPT>(_context);
                }
                return schedExceptRepo;
            }
        }
        public IGenericDataRepository<ISR_UDF> IsrUdfRepo
        {
            get
            {
                if (this.isrUdfRepo == null)
                {
                    this.isrUdfRepo = new GenericDataRepository<ISR_UDF>(_context);
                }
                return isrUdfRepo;
            }
        }
        public IGenericDataRepository<FILE_ATTACHMENT> FileAttachmentRepo
        {
            get
            {
                if (this.fileAttachmentRepo == null)
                {
                    this.fileAttachmentRepo = new GenericDataRepository<FILE_ATTACHMENT>(_context);
                }
                return fileAttachmentRepo;
            }
        }
        public IGenericDataRepository<FILE_DEFINITION> FileDefinitionRepo
        {
            get
            {
                if (this.fileDefinitionRepo == null)
                {
                    this.fileDefinitionRepo = new GenericDataRepository<FILE_DEFINITION>(_context);
                }
                return fileDefinitionRepo;
            }
        }

        public IGenericDataRepository<SERVICE_CODE> ServiceCodeRepo
        {
            get
            {
                if (this.serviceCodeRepo == null)
                {
                    this.serviceCodeRepo = new GenericDataRepository<SERVICE_CODE>(_context);
                }
                return serviceCodeRepo;
            }
        }
        public IGenericDataRepository<C02_ISR_DISPOS> C02IsrDisposRepo
        {
            get
            {
                if (this.c02IsrDisposRepo == null)
                {
                    this.c02IsrDisposRepo = new GenericDataRepository<C02_ISR_DISPOS>(_context);
                }
                return c02IsrDisposRepo;
            }
        }
        public IGenericDataRepository<C05_ISR_COMM_HEAD> C05IsrCommHeadRepo
        {
            get
            {
                if (this.c05IsrCommHeadRepo == null)
                {
                    this.c05IsrCommHeadRepo = new GenericDataRepository<C05_ISR_COMM_HEAD>(_context);
                }
                return C05IsrCommHeadRepo;
            }
        }
        public IGenericDataRepository<C06_ISR_COMMENT> C06IsrCommentRepo
        {
            get
            {
                if (this.c06IsrCommentRepo == null)
                {
                    this.c06IsrCommentRepo = new GenericDataRepository<C06_ISR_COMMENT>(_context);
                }
                return c06IsrCommentRepo;
            }
        }
        public IGenericDataRepository<SCREEN2_HEADER> Screen2HeaderRepo
        {
            get
            {
                if (this.screen2HeaderRepo == null)
                {
                    this.screen2HeaderRepo = new GenericDataRepository<SCREEN2_HEADER>(_context);
                }
                return screen2HeaderRepo;
            }
        }
        public IGenericDataRepository<UDF_CONTAINER> UdfContainerRepo
        {
            get
            {
                if (this.udfContainerRepo == null)
                {
                    this.udfContainerRepo = new GenericDataRepository<UDF_CONTAINER>(_context);
                }
                return udfContainerRepo;
            }
        }
        public IGenericDataRepository<UDF_CONTAINER_NODE> UdfContainerNodeRepo
        {
            get
            {
                if (this.udfContainerNodeRepo == null)
                {
                    this.udfContainerNodeRepo = new GenericDataRepository<UDF_CONTAINER_NODE>(_context);
                }
                return udfContainerNodeRepo;
            }
        }
        public IGenericDataRepository<UDF_NODE_SCREEN_RELATION> UdfNodeScreenRelationRepo
        {
            get
            {
                if (this.udfNodeScreenRelationRepo == null)
                {
                    this.udfNodeScreenRelationRepo = new GenericDataRepository<UDF_NODE_SCREEN_RELATION>(_context);
                }
                return udfNodeScreenRelationRepo;
            }
        }
        
        public IVtbCodeRepository VTBCodeRepo
        {
            get
            {
                if (this.vtbCodeRepo == null)
                {
                    this.vtbCodeRepo = new VtbCodeRepository(_context);
                }
                return vtbCodeRepo;
            }
        }
        public IGenericDataRepository<D11_UNIT_ACTIVITY> UnitActivityRepo
        {
            get
            {
                if (this.unitActivityRepo == null)
                {
                    this.unitActivityRepo = new GenericDataRepository<D11_UNIT_ACTIVITY>(_context);
                }
                return unitActivityRepo;
            }
        }
        public IGenericDataRepository<D16_MEMB_ACTIVITY> MemberActivityRepo
        {
            get
            {
                if (this.memberActivityRepo == null)
                {
                    this.memberActivityRepo = new GenericDataRepository<D16_MEMB_ACTIVITY>(_context);
                }
                return memberActivityRepo;
            }
        }
        public IGenericDataRepository<S02_SHIFT_DETAIL> S02ShiftDetailRepo
        {
            get
            {
                if (this.s02ShiftDetailRepo == null)
                {
                    this.s02ShiftDetailRepo = new GenericDataRepository<S02_SHIFT_DETAIL>(_context);
                }
                return s02ShiftDetailRepo;
            }
        }
        public IGenericDataRepository<DP_UNIT> DpUnitRepo
        {
            get
            {
                if (this.dpUnitRepo == null)
                {
                    this.dpUnitRepo = new GenericDataRepository<DP_UNIT>(_context);
                }
                return dpUnitRepo;
            }
        }
       
        public IGenericDataRepository<EQUIPMENT> EquipmentRepo
        {
            get
            {
                if (this.equipmentRepo == null)
                {
                    this.equipmentRepo = new GenericDataRepository<EQUIPMENT>(_context);
                }
                return equipmentRepo;
            }
        }
        public IGenericDataRepository<C03_ASSIGN> AssignRepo
        {
            get
            {
                if (this.assignRepo == null)
                {
                    this.assignRepo = new GenericDataRepository<C03_ASSIGN>(_context);
                }
                return assignRepo;
            }
        }
        public IGenericDataRepository<ALL_TAB_COLS> AllTabsColsRepo
        {
            get
            {
                if (this.allTabsColsRepo == null)
                {
                    this.allTabsColsRepo = new GenericDataRepository<ALL_TAB_COLS>(_context);
                }
                return allTabsColsRepo;
            }
        }
        public IGenericDataRepository<PERSONNEL_SKILL> PersonnelSkillRepo
        {
            get
            {
                if (this.personnelSkillRepo == null)
                {
                    this.personnelSkillRepo = new GenericDataRepository<PERSONNEL_SKILL>(_context);
                }
                return personnelSkillRepo;
            }
        }
        public IGenericDataRepository<CAD_PARAMETERS> CadPremetersRepo
        {
            get
            {
                if (this.cadParametersRepo == null)
                {
                    this.cadParametersRepo = new GenericDataRepository<CAD_PARAMETERS>(_context);
                }
                return cadParametersRepo;
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public bool CheckDatabase()
        {
            return _context.Database.Exists();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

         public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
