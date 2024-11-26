﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CNPM_PKDT.Module.database
{

    [DefaultProperty("NgayTao")]
    public partial class DONHANG : DevExpress.Persistent.BaseImpl.BaseObject
    {
        KHACHHANG fID_KHACHHANG;
        [Association(@"DONHANGReferencesKHACHHANG")]
        public KHACHHANG ID_KHACHHANG
        {
            get { return fID_KHACHHANG; }
            set { SetPropertyValue<KHACHHANG>(nameof(ID_KHACHHANG), ref fID_KHACHHANG, value); }
        }
        DateTime fNgayTao;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime NgayTao
        {
            get { return fNgayTao; }
            set { SetPropertyValue<DateTime>(nameof(NgayTao), ref fNgayTao, value); }
        }
        string fTongTien;
        public string TongTien
        {
            get { return fTongTien; }
            set { SetPropertyValue<string>(nameof(TongTien), ref fTongTien, value); }
        }
        string fTrangThai;
        [Size(50)]
        public string TrangThai
        {
            get { return fTrangThai; }
            set { SetPropertyValue<string>(nameof(TrangThai), ref fTrangThai, value); }
        }
        NHANVIEN fID_NHANVIEN;
        [Association(@"DONHANGReferencesNHANVIEN")]
        public NHANVIEN ID_NHANVIEN
        {
            get { return fID_NHANVIEN; }
            set { SetPropertyValue<NHANVIEN>(nameof(ID_NHANVIEN), ref fID_NHANVIEN, value); }
        }
        [Association(@"PHIEUBAOHANHReferencesDONHANG")]
        public XPCollection<PHIEUBAOHANH> PHIEUBAOHANHs { get { return GetCollection<PHIEUBAOHANH>(nameof(PHIEUBAOHANHs)); } }
        [Association(@"DONVANCHUYENReferencesDONHANG")]
        public XPCollection<DONVANCHUYEN> DONVANCHUYENs { get { return GetCollection<DONVANCHUYEN>(nameof(DONVANCHUYENs)); } }
    }

}
