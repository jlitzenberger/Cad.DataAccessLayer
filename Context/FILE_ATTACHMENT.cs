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
    
    public partial class FILE_ATTACHMENT
    {
        public int FILE_DEFINITION_ID { get; set; }
        public int FILE_ATTACHMENT_ID { get; set; }
        public short FILE_ATTACHMENT_TYPE { get; set; }
        public int CREATION_PERSONNEL_ID { get; set; }
        public string CREATION_PERSONNEL_NAME { get; set; }
        public System.DateTimeOffset CREATION_DATETIME { get; set; }
        public int MOD_PERSONNEL_ID { get; set; }
        public string MOD_PERSONNEL_NAME { get; set; }
        public System.DateTimeOffset MOD_DATETIME { get; set; }
    
        public virtual FILE_DEFINITION FILE_DEFINITION { get; set; }
    }
}
