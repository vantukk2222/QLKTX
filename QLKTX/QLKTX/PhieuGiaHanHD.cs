//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKTX
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuGiaHanHD
    {
        public string MaPhieu { get; set; }
        public string MaHopDong { get; set; }
        public System.DateTime ThoiGianGiaHan { get; set; }
    
        public virtual HopDong HopDong { get; set; }
        public virtual Phieu Phieu { get; set; }
    }
}
