//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schools
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schools()
        {
            this.Managers = new HashSet<Managers>();
            this.Years = new HashSet<Years>();
        }
    
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public string SchoolNameEn { get; set; }
        public System.DateTime School_Crea_Date { get; set; }
        public string SchoolVison { get; set; }
        public string SchoolMission { get; set; }
        public string SchoolGoal { get; set; }
        public string Notes { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int SchoolPhone { get; set; }
        public string Street { get; set; }
        public string SchoolType { get; set; }
        public string Email { get; set; }
        public Nullable<int> fax { get; set; }
        public string zone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Managers> Managers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Years> Years { get; set; }
    }
}
