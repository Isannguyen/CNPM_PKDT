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

    [DefaultProperty("NgayLap")]
    public partial class PHIEUBAOHANH : DevExpress.Persistent.BaseImpl.BaseObject
    {
        DONHANG fID_DONHANG;
        public DONHANG ID_DONHANG
        {
            get { return fID_DONHANG; }
            set { SetPropertyValue<DONHANG>(nameof(ID_DONHANG), ref fID_DONHANG, value); }
        }
        DateTime fNgayLap;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime NgayLap
        {
            get { return fNgayLap; }
            set { SetPropertyValue<DateTime>(nameof(NgayLap), ref fNgayLap, value); }
        }
        [Association(@"PHIEUBAOHANHReferencesDONHANG")]
        public XPCollection<DONHANG> DONHANGs { get { return GetCollection<DONHANG>(nameof(DONHANGs)); } }
        [Association(@"DONBAOHANHReferencesPHIEUBAOHANH"), Aggregated]
        public XPCollection<DONBAOHANH> DONBAOHANHs { get { return GetCollection<DONBAOHANH>(nameof(DONBAOHANHs)); } }
    }

}
