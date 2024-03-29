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
    
    public partial class C03_ASSIGN
    {
        public string ISR_NO { get; set; }
        public string AGENCY_CODE { get; set; }
        public string UNIT { get; set; }
        public string S02_SHIFT_CODE { get; set; }
        public string SHIFT_DATE { get; set; }
        public string B07_CURRENT_STATUS { get; set; }
        public Nullable<System.DateTimeOffset> C03_CUR_STAT_DATETIME { get; set; }
        public Nullable<int> DISPATCH_ID { get; set; }
        public Nullable<System.DateTimeOffset> C03_SCHED_DATETIME { get; set; }
        public Nullable<System.DateTimeOffset> START_DATETIME { get; set; }
        public Nullable<int> TRAVEL_TIME { get; set; }
        public Nullable<int> C03_ESTIMATED_TIME { get; set; }
        public Nullable<System.DateTimeOffset> C03_EST_COMPL_DATETIME { get; set; }
        public string C03_TX_ACK { get; set; }
        public Nullable<System.DateTimeOffset> TIMER_EXP_DATETIME { get; set; }
        public string P_TIMER_EXP_CODE { get; set; }
        public string C03S_CAD_ACTION { get; set; }
        public string C03P_ORDER { get; set; }
        public short C03_APPOINTMENT { get; set; }
        public string C03S_ORIGIN { get; set; }
        public string PROFILE_NAME { get; set; }
        public Nullable<System.DateTimeOffset> ACTUAL_START_DATETIME { get; set; }
        public Nullable<System.DateTimeOffset> ACTUAL_COMPLETION_DATETIME { get; set; }
        public Nullable<int> ACTUAL_WORK_MINUTE { get; set; }
        public Nullable<int> ACTUAL_TRAVEL_MINUTE { get; set; }
        public Nullable<int> ACTUAL_REMAIN_WORK_MINUTE { get; set; }
        public short ACTUAL_AUTO_CALCULATE_FLG { get; set; }
        public short GDM_MANUAL_SCHEDULE { get; set; }
        public short MANUAL_SCHEDULE_MODE { get; set; }
        public decimal ORIGINAL_ESTIMATED_TIME { get; set; }
        public short MANPOWER_ADJMT_FACTOR { get; set; }
        public Nullable<decimal> TAZ_TRAVEL_TIME_ADJMT_PCT { get; set; }
        public Nullable<decimal> TAZ_WORK_TIME_ADJMT_PCT { get; set; }
        public Nullable<System.DateTimeOffset> START_AFTER_DATETIME { get; set; }
        public string HELD_BY_CREW_FLG { get; set; }
        public decimal SKILL_LEVEL_ADJUSTMENT_PCT { get; set; }
        public string ASSIGNMENT_EXCEPTION_FLG { get; set; }
        public string ASSIGNMENT_STATUS_BEFORE_LUNCH { get; set; }
        public int KEY_ID { get; set; }
        public int MOD_PERSONNEL_ID { get; set; }
        public System.DateTimeOffset MOD_DATETIME { get; set; }
    
        public virtual ISR ISR { get; set; }
    }
}
