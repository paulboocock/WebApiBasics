using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records; 

namespace WebApiBasics.Data.Maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
			Table("SalesLT.Product");
			Id(x => x.ProductId).GeneratedBy.Identity().Column("ProductID");
			References(x => x.ProductCategory).Column("ProductCategoryID");
			References(x => x.ProductModel).Column("ProductModelID");
			Map(x => x.Name).Column("Name").Not.Nullable().Unique();
			Map(x => x.ProductNumber).Column("ProductNumber").Not.Nullable().Unique();
			Map(x => x.Color).Column("Color");
			Map(x => x.StandardCost).Column("StandardCost").Not.Nullable();
			Map(x => x.ListPrice).Column("ListPrice").Not.Nullable();
			Map(x => x.Size).Column("Size");
			Map(x => x.Weight).Column("Weight");
			Map(x => x.SellStartDate).Column("SellStartDate").Not.Nullable();
			Map(x => x.SellEndDate).Column("SellEndDate");
			Map(x => x.DiscontinuedDate).Column("DiscontinuedDate");
			Map(x => x.ThumbNailPhoto).Column("ThumbNailPhoto");
			Map(x => x.ThumbnailPhotoFileName).Column("ThumbnailPhotoFileName");
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique();
			Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
			HasMany(x => x.SalesOrderDetails).KeyColumn("ProductID");
        }
    }
}
