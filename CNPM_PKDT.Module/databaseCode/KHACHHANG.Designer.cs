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

    [DefaultProperty("Ten")]
    public partial class KHACHHANG : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fTen;
        [Size(50)]
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>(nameof(Ten), ref fTen, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fDiaChi;
        [Size(50)]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fSoDienThoai;
        [Size(50)]
        public string SoDienThoai
        {
            get { return fSoDienThoai; }
            set { SetPropertyValue<string>(nameof(SoDienThoai), ref fSoDienThoai, value); }
        }
        string fMatKhau;
        [Size(50)]
        public string MatKhau
        {
            get { return fMatKhau; }
            set { SetPropertyValue<string>(nameof(MatKhau), ref fMatKhau, value); }
        }
        [Association(@"DONHANGReferencesKHACHHANG"), Aggregated]
        public XPCollection<DONHANG> DONHANGs { get { return GetCollection<DONHANG>(nameof(DONHANGs)); } }
    }

}
