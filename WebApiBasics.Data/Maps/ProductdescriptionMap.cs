using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records;

namespace WebApiBasics.Data.Maps
{
    public class ProductDescriptionMap : ClassMap<ProductDescription>
    {
        public ProductDescriptionMap()
        {
			Table("SalesLT.ProductDescription");
			Id(x => x.ProductDescriptionId).GeneratedBy.Identity().Column("ProductDescriptionID");
			Map(x => x.Description).Column("Description").Not.Nullable();
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
			HasMany(x => x.ProductModelProductDescription).KeyColumn("ProductDescriptionID");
        }
    }
}
