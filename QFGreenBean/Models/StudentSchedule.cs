//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFGreenBean.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentSchedule
    {
        public int StudentScheduleId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> SectionId { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual Student Student { get; set; }
    }
}
