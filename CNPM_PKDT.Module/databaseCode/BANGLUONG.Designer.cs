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

    [DefaultProperty("Email")]
    public partial class BANGLUONG : DevExpress.Persistent.BaseImpl.BaseObject
    {
        NHANVIEN fID_NHANVIEN;
        [Association(@"BANGLUONGReferencesNHANVIEN")]
        public NHANVIEN ID_NHANVIEN
        {
            get { return fID_NHANVIEN; }
            set { SetPropertyValue<NHANVIEN>(nameof(ID_NHANVIEN), ref fID_NHANVIEN, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fNam;
        public string Nam
        {
            get { return fNam; }
            set { SetPropertyValue<string>(nameof(Nam), ref fNam, value); }
        }
        string fThang;
        public string Thang
        {
            get { return fThang; }
            set { SetPropertyValue<string>(nameof(Thang), ref fThang, value); }
        }
        string fSoGio;
        public string SoGio
        {
            get { return fSoGio; }
            set { SetPropertyValue<string>(nameof(SoGio), ref fSoGio, value); }
        }
        string fLuong;
        public string Luong
        {
            get { return fLuong; }
            set { SetPropertyValue<string>(nameof(Luong), ref fLuong, value); }
        }
    }

}
