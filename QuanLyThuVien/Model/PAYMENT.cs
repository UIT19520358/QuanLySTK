//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAYMENT
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DatePayment { get; set; }
        public int IdPassbook { get; set; }
        public int IdCustomer { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual PASSBOOK PASSBOOK { get; set; }
    }
}
