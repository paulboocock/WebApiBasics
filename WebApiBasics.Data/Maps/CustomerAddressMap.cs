using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records;

namespace WebApiBasics.Data.Maps
{
    public class CustomerAddressMap : ClassMap<CustomerAddress>
    {
        public CustomerAddressMap()
        {
			Table("SalesLT.CustomerAddress");
			CompositeId().KeyProperty(x => x.CustomerId, "CustomerID")
			             .KeyProperty(x => x.AddressId, "AddressID");
			References(x => x.Customer).Column("CustomerID");
			References(x => x.Address).Column("AddressID");
			Map(x => x.AddressType).Column("AddressType").Not.Nullable();
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
