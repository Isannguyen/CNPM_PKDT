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

    [DefaultProperty("So")]
    public partial class PHIEUNHAP : DevExpress.Persistent.BaseImpl.BaseObject
    {
        NCC fID_NCC;
        [Association(@"PHIEUNHAPReferencesNCC")]
        public NCC ID_NCC
        {
            get { return fID_NCC; }
            set { SetPropertyValue<NCC>(nameof(ID_NCC), ref fID_NCC, value); }
        }
        string fSo;
        public string So
        {
            get { return fSo; }
            set { SetPropertyValue<string>(nameof(So), ref fSo, value); }
        }
        DateTime fNgay;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return fNgay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref fNgay, value); }
        }
        [Association(@"DONGNHAPReferencesPHIEUNHAP"), Aggregated]
        public XPCollection<DONGNHAP> DONGNHAPs { get { return GetCollection<DONGNHAP>(nameof(DONGNHAPs)); } }
    }

}
