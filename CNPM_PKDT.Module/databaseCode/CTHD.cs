using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CNPM_PKDT.Module.database
{

    public partial class CTHD
    {
        public CTHD(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
