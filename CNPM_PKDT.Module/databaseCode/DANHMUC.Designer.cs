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

    [DefaultProperty("TenDM")]
    public partial class DANHMUC : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fTenDM;
        public string TenDM
        {
            get { return fTenDM; }
            set { SetPropertyValue<string>(nameof(TenDM), ref fTenDM, value); }
        }
        string fLoaiDM;
        [Size(50)]
        public string LoaiDM
        {
            get { return fLoaiDM; }
            set { SetPropertyValue<string>(nameof(LoaiDM), ref fLoaiDM, value); }
        }
        NCC fID_NCC;
        [Association(@"DANHMUCReferencesNCC")]
        public NCC ID_NCC
        {
            get { return fID_NCC; }
            set { SetPropertyValue<NCC>(nameof(ID_NCC), ref fID_NCC, value); }
        }
        [Association(@"SANPHAMReferencesDANHMUC"), Aggregated]
        public XPCollection<SANPHAM> SANPHAMs { get { return GetCollection<SANPHAM>(nameof(SANPHAMs)); } }
    }

}
