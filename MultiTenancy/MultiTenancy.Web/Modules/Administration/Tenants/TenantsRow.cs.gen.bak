
namespace MultiTenancy.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Administration"), TableName("[dbo].[Tenants]")]
    [DisplayName("Tenants"), InstanceName("Tenants")]
    [ReadPermission("Administration:Tenants")]
    [ModifyPermission("Administration:Tenants")]
    public sealed class TenantsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tenant Id"), Identity]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Tenant Name"), Size(100), NotNull, QuickSearch]
        public String TenantName
        {
            get { return Fields.TenantName[this]; }
            set { Fields.TenantName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TenantId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TenantName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TenantsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TenantId;
            public StringField TenantName;
        }
    }
}
