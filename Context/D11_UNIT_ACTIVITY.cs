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
    
    public partial class D11_UNIT_ACTIVITY
    {
        public string AGENCY_CODE { get; set; }
        public string UNIT { get; set; }
        public System.DateTimeOffset D11_START_DATETIME { get; set; }
        public string B07_STATUS_CODE { get; set; }
        public string ISR_NO { get; set; }
        public Nullable<System.DateTimeOffset> D11_END_DATETIME { get; set; }
        public string D11_CAD_ACTION { get; set; }
        public string S02_SHIFT_CODE { get; set; }
        public string SHIFT_DATE { get; set; }
        public string SERVICE_CODE { get; set; }
        public string D11_CURRENT_LOC { get; set; }
        public string C03S_ORIGIN { get; set; }
        public Nullable<decimal> LONGITUDE { get; set; }
        public Nullable<decimal> LATITUDE { get; set; }
    
        public virtual B07_STATUS B07_STATUS { get; set; }
        public virtual DP_UNIT DP_UNIT { get; set; }
    }
}
