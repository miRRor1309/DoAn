//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHD
    {
        public string IDCTHoaDon { get; set; }
        public int Quantity { get; set; }
        public System.DateTime NgayMua { get; set; }
        public double TongTien { get; set; }
        public string MaDH { get; set; }
        public string GhiChuKH { get; set; }
    
        public virtual DonHang DonHang { get; set; }
    }
}
