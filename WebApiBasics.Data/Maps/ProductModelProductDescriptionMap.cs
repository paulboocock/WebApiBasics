using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records;

namespace WebApiBasics.Data.Maps
{
    public class ProductModelProductDescriptionMap : ClassMap<ProductModelProductDescription>
    {
        public ProductModelProductDescriptionMap()
        {
			Table("SalesLT.ProductModelProductDescription");
			CompositeId().KeyProperty(x => x.ProductModelId, "ProductModelID")
			             .KeyProperty(x => x.ProductDescriptionId, "ProductDescriptionID")
			             .KeyProperty(x => x.Culture, "Culture");
			References(x => x.ProductModel).Column("ProductModelID");
			References(x => x.ProductDescription).Column("ProductDescriptionID");
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique();
			Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
