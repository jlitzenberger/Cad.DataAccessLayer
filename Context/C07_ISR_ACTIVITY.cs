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
    
    public partial class C07_ISR_ACTIVITY
    {
        public string C07_ACTIVITY_CODE { get; set; }
        public System.DateTimeOffset C07_START_DATETIME { get; set; }
        public short C07_IS_STATUS { get; set; }
        public Nullable<int> MOD_PERSONNEL_ID { get; set; }
    
        public virtual ISR ISR { get; set; }
        public virtual B07_STATUS B07_STATUS { get; set; }
    }
}