using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records; 

namespace WebApiBasics.Data.Maps
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
			Table("SalesLT.Customer");
			Id(x => x.CustomerID).GeneratedBy.Identity().Column("CustomerID");
			Map(x => x.NameStyle).Column("NameStyle").Not.Nullable();
			Map(x => x.Title).Column("Title");
			Map(x => x.FirstName).Column("FirstName").Not.Nullable();
			Map(x => x.MiddleName).Column("MiddleName");
			Map(x => x.LastName).Column("LastName").Not.Nullable();
			Map(x => x.Suffix).Column("Suffix");
			Map(x => x.CompanyName).Column("CompanyName");
			Map(x => x.SalesPerson).Column("SalesPerson");
			Map(x => x.EmailAddress).Column("EmailAddress");
			Map(x => x.Phone).Column("Phone");
			Map(x => x.PasswordHash).Column("PasswordHash").Not.Nullable();
			Map(x => x.PasswordSalt).Column("PasswordSalt").Not.Nullable();
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
			HasMany(x => x.CustomerAddresses).KeyColumn("CustomerID");
			HasMany(x => x.SalesOrderHeaders).KeyColumn("CustomerID");
        }
    }
}
