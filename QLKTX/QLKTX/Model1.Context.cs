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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLKTXEntities1 : DbContext
    {
        public QLKTXEntities1()
            : base("name=QLKTXEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccCB> AccCBs { get; set; }
        public virtual DbSet<AccSV> AccSVs { get; set; }
        public virtual DbSet<CanBoQuanLy> CanBoQuanLies { get; set; }
        public virtual DbSet<DienNuoc> DienNuocs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<Khu> Khus { get; set; }
        public virtual DbSet<Phieu> Phieux { get; set; }
        public virtual DbSet<PhieuDangKyOKTX> PhieuDangKyOKTXes { get; set; }
        public virtual DbSet<PhieuGiaHanHD> PhieuGiaHanHDs { get; set; }
        public virtual DbSet<PhieuKyLuat> PhieuKyLuats { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<SV> SVs { get; set; }
    }
}
