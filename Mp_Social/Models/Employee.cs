//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mp_Social.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<int> Married { get; set; }
        public Nullable<System.DateTime> Join_Date { get; set; }
        public System.Guid Department_ID { get; set; }
        public string avatar { get; set; }
        public string pic1 { get; set; }
        public string pic2 { get; set; }
        public string pic3 { get; set; }
        public string pic4 { get; set; }
        public string Note { get; set; }
        public string job_note { get; set; }
        public Nullable<System.Guid> Branch_ID { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Department Department { get; set; }
    }
}
