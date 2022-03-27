
namespace MultiTenancy.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Administration.Tenants")]
    [BasedOnRow(typeof(Entities.TenantsRow), CheckNames = true)]
    public class TenantsForm
    {
        public String TenantName { get; set; }
    }
}