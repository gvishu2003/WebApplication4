//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShiftMaster
    {
        public int Id { get; set; }
        public string cShiftCode { get; set; }
        public string cShiftDesc { get; set; }
        public string cTotalHrs { get; set; }
        public string cTotalSwipe { get; set; }
        public string cTotalFixed { get; set; }
        public Nullable<int> cTotalFixedValue { get; set; }
        public string cTotalLHrs { get; set; }
        public string cTotalLSwipe { get; set; }
        public string cTotalLFixed { get; set; }
        public Nullable<int> cTotalLFixedValue { get; set; }
        public Nullable<int> nShiftStart { get; set; }
        public Nullable<int> nShiftEnd { get; set; }
        public Nullable<int> nLunchStart { get; set; }
        public Nullable<int> nLunchEnd { get; set; }
        public Nullable<int> nGraceIn { get; set; }
        public Nullable<int> nGraceOut { get; set; }
        public Nullable<int> nBefore { get; set; }
        public Nullable<int> nAfter { get; set; }
        public Nullable<int> nOTBefore { get; set; }
        public Nullable<int> nOTAfter { get; set; }
        public string cLocationCode { get; set; }
        public string cPrimary { get; set; }
    }
}
