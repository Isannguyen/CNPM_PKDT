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

    [DefaultProperty("TenNV")]
    public partial class NHANVIEN : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fTenNV;
        public string TenNV
        {
            get { return fTenNV; }
            set { SetPropertyValue<string>(nameof(TenNV), ref fTenNV, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fDiaChi;
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fMucLuong;
        public string MucLuong
        {
            get { return fMucLuong; }
            set { SetPropertyValue<string>(nameof(MucLuong), ref fMucLuong, value); }
        }
        string fMatKhau;
        public string MatKhau
        {
            get { return fMatKhau; }
            set { SetPropertyValue<string>(nameof(MatKhau), ref fMatKhau, value); }
        }
        [Association(@"BANGLUONGReferencesNHANVIEN"), Aggregated]
        public XPCollection<BANGLUONG> BANGLUONGs { get { return GetCollection<BANGLUONG>(nameof(BANGLUONGs)); } }
        [Association(@"CHAMCONGReferencesNHANVIEN"), Aggregated]
        public XPCollection<CHAMCONG> CHAMCONGs { get { return GetCollection<CHAMCONG>(nameof(CHAMCONGs)); } }
        [Association(@"PHIEUCHIReferencesNHANVIEN"), Aggregated]
        public XPCollection<PHIEUCHI> PHIEUCHIs { get { return GetCollection<PHIEUCHI>(nameof(PHIEUCHIs)); } }
        [Association(@"DONHANGReferencesNHANVIEN"), Aggregated]
        public XPCollection<DONHANG> DONHANGs { get { return GetCollection<DONHANG>(nameof(DONHANGs)); } }
    }

}