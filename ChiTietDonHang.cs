//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MINHTUANMOBILE
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public string MaCTDH { get; set; }
        public string MaDH { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Hinh { get; set; }
        public string DungLuong { get; set; }
        public string MauSac { get; set; }
        public string HeDieuHanh { get; set; }
        public string BaoHanh { get; set; }
        public string ChiNhanh { get; set; }
        public string ThuongHieu { get; set; }
        public Nullable<double> GiaBan { get; set; }
        public Nullable<int> SoLuongMua { get; set; }
        public string MaKM { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
