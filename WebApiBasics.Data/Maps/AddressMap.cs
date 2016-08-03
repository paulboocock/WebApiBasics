using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records; 

namespace WebApiBasics.Data.Maps
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
			Table("SalesLT.Address");
			Id(x => x.AddressID).GeneratedBy.Identity().Column("AddressID");
			Map(x => x.AddressLine1).Column("AddressLine1").Not.Nullable();
			Map(x => x.AddressLine2).Column("AddressLine2");
			Map(x => x.City).Column("City").Not.Nullable();
			Map(x => x.StateProvince).Column("StateProvince").Not.Nullable();
			Map(x => x.CountryRegion).Column("CountryRegion").Not.Nullable();
			Map(x => x.PostalCode).Column("PostalCode").Not.Nullable();
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
			HasMany(x => x.CustomerAddress).KeyColumn("AddressID");
			HasMany(x => x.BillingSalesOrderHeaders).KeyColumn("BillToAddressID");
			HasMany(x => x.ShippingSalesOrderHeaders).KeyColumn("ShipToAddressID");
        }
    }
}
