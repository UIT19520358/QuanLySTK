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
    
    public partial class USERINFO
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
    
        public virtual USERROLE USERROLE { get; set; }
    }
}
