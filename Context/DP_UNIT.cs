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
    
    public partial class DP_UNIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_UNIT()
        {
            this.D11_UNIT_ACTIVITY = new HashSet<D11_UNIT_ACTIVITY>();
            this.D16_MEMB_ACTIVITY = new HashSet<D16_MEMB_ACTIVITY>();
        }
    
        public string AGENCY_CODE { get; set; }
        public string UNIT { get; set; }
        public string S02_SHIFT_CODE { get; set; }
        public string SHIFT_DATE { get; set; }
        public string G01_LEVEL_CODE { get; set; }
        public string DEFAULT_STATION { get; set; }
        public string P_PLAN_CODE { get; set; }
        public System.DateTimeOffset START_DATETIME { get; set; }
        public short START_LOCATION_TYPE { get; set; }
        public Nullable<int> START_LOCATION_ID { get; set; }
        public Nullable<decimal> START_LONGITUDE { get; set; }
        public Nullable<decimal> START_LATITUDE { get; set; }
        public short FIRST_JOB_TRAVEL_TIME_FLG { get; set; }
        public System.DateTimeOffset END_DATETIME { get; set; }
        public Nullable<int> END_LOCATION_ID { get; set; }
        public Nullable<decimal> END_LONGITUDE { get; set; }
        public Nullable<decimal> END_LATITUDE { get; set; }
        public Nullable<short> USER_ROUTING { get; set; }
        public Nullable<int> LEADER_PERS_ID { get; set; }
        public Nullable<int> MAIN_VEHICLE_ID { get; set; }
        public string DEFAULT_SERV_CODE { get; set; }
        public string SERVICE_CODE { get; set; }
        public string P_SPECIAL_GROUP { get; set; }
        public string CURRENT_STATION { get; set; }
        public string P_DISPATCHER_GROUP { get; set; }
        public string P_SUPERVISOR_GROUP { get; set; }
        public Nullable<short> OVERT_AVAIL { get; set; }
        public Nullable<int> MAX_OVERTIME_DURATION { get; set; }
        public Nullable<decimal> LONGITUDE { get; set; }
        public Nullable<decimal> LATITUDE { get; set; }
        public string ACTIVE_ISR_NO { get; set; }
        public string COVERED_BY_AGENCY { get; set; }
        public string COVERED_BY_UNIT { get; set; }
        public string S_MODE { get; set; }
        public string B07_STATUS_CODE { get; set; }
        public Nullable<System.DateTimeOffset> STATUS_DATETIME { get; set; }
        public Nullable<short> TAG_FLAG { get; set; }
        public string PRIMARY_DP_ZONE { get; set; }
        public string CURRENT_DP_ZONE { get; set; }
        public string CURRENT_LOCATION { get; set; }
        public short MEMBER_COUNT { get; set; }
        public string D02P_FIRST_TYPE { get; set; }
        public Nullable<int> EST_TIME_SCHED { get; set; }
        public Nullable<int> EST_TIME_UNSCHED { get; set; }
        public Nullable<short> IN_COMMUNICATION { get; set; }
        public Nullable<System.DateTimeOffset> LAST_COMM_DATETIME { get; set; }
        public Nullable<System.DateTimeOffset> TIMER_EXP_DATETIME { get; set; }
        public string P_TIMER_EXP_CODE { get; set; }
        public Nullable<int> S02_SHIFT_WORKLOAD { get; set; }
        public string P_FILTER1 { get; set; }
        public string P_FILTER2 { get; set; }
        public string P_FILTER3 { get; set; }
        public string LOGIN_NAME { get; set; }
        public Nullable<decimal> MIN_DIST_TO_BROADCAST { get; set; }
        public Nullable<decimal> MIN_TIME_TO_BROADCAST { get; set; }
        public Nullable<decimal> MAX_TIME_TO_BROADCAST { get; set; }
        public Nullable<System.DateTimeOffset> GPS_FREQ_EXP_DATETIME { get; set; }
        public Nullable<decimal> GPS_STATE_BIT_MASK { get; set; }
        public string CALCULATE_TIME_ADJMT_FLG { get; set; }
        public Nullable<short> LUNCH_DURATION_MINUTE { get; set; }
        public Nullable<System.DateTimeOffset> LUNCH_DATETIME { get; set; }
        public Nullable<decimal> RECMD_SEARCH_RADIUS { get; set; }
        public string DISPATCH_TRIGGER_STATUS { get; set; }
        public Nullable<short> ACTIVATE_BEFORE_MINUTE { get; set; }
        public Nullable<short> DEACTIVATE_AFTER_MINUTE { get; set; }
        public string UNASGN_ON_PLANDEACTIVATE_FLG { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
        public string UDF6 { get; set; }
        public string UDF7 { get; set; }
        public string UDF8 { get; set; }
        public string UDF9 { get; set; }
        public string UDF10 { get; set; }
        public string UDF11 { get; set; }
        public string UDF12 { get; set; }
        public string UDF13 { get; set; }
        public string UDF14 { get; set; }
        public string UDF15 { get; set; }
        public string UDF16 { get; set; }
        public string UDF17 { get; set; }
        public string UDF18 { get; set; }
        public string UDF19 { get; set; }
        public string UDF20 { get; set; }
        public string UDF21 { get; set; }
        public string UDF22 { get; set; }
        public string UDF23 { get; set; }
        public string UDF24 { get; set; }
        public int KEY_ID { get; set; }
        public int MOD_PERSONNEL_ID { get; set; }
        public System.DateTimeOffset MOD_DATETIME { get; set; }
    
        public virtual B07_STATUS B07_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D11_UNIT_ACTIVITY> D11_UNIT_ACTIVITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D16_MEMB_ACTIVITY> D16_MEMB_ACTIVITY { get; set; }
        public virtual ISR ISR { get; set; }
        public virtual S02_SHIFT_DETAIL S02_SHIFT_DETAIL { get; set; }
        public virtual SERVICE_CODE SERVICE_CODE1 { get; set; }
    }
}
