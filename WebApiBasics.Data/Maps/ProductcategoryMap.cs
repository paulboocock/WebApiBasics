using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records; 

namespace WebApiBasics.Data.Maps
{
    public class ProductCategoryMap : ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
			Table("SalesLT.ProductCategory");
			Id(x => x.ProductCategoryId).GeneratedBy.Identity().Column("ProductCategoryID");
			References(x => x.ParentProductCategory).Column("ParentProductCategoryID");
			Map(x => x.Name).Column("Name").Not.Nullable().Unique();
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
			HasMany(x => x.Products).KeyColumn("ProductCategoryID");
			HasMany(x => x.ChildrenProductCategories).KeyColumn("ParentProductCategoryID");
        }
    }
}
