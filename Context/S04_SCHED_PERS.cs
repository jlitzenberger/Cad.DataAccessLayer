//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cad.DataAccessLayer.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class S04_SCHED_PERS
    {
        public string AGENCY_CODE { get; set; }
        public string S01_TEAM_SCHED { get; set; }
        public int PERSONNEL_ID { get; set; }
        public string S04_START_DATE { get; set; }
        public string S04_END_DATE { get; set; }
        public short S03_START_DAY { get; set; }
        public int MOD_PERSONNEL_ID { get; set; }
        public System.DateTimeOffset MOD_DATETIME { get; set; }
    
        public virtual PERSONNEL PERSONNEL { get; set; }
    }
}
