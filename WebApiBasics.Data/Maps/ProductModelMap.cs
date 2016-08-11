using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records;

namespace WebApiBasics.Data.Maps
{
    public class ProductModelMap : ClassMap<ProductModel>
    {
        public ProductModelMap()
        {
			Table("SalesLT.ProductModel");
			Id(x => x.ProductModelId).GeneratedBy.Identity().Column("ProductModelID");
			Map(x => x.Name).Column("Name").Not.Nullable().Unique();
			Map(x => x.CatalogDescription).Column("CatalogDescription");
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
			HasMany(x => x.Product).KeyColumn("ProductModelID");
			HasMany(x => x.ProductModelProductDescription).KeyColumn("ProductModelID");
        }
    }
}
