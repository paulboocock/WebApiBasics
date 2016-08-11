using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records; 

namespace WebApiBasics.Data.Maps
{
    public class SalesOrderDetailMap : ClassMap<SalesOrderDetail>
    {
        public SalesOrderDetailMap()
        {
			Table("SalesLT.SalesOrderDetail");
			CompositeId().KeyProperty(x => x.SalesOrderId, "SalesOrderID")
			             .KeyProperty(x => x.SalesOrderDetailId, "SalesOrderDetailID");
			References(x => x.SalesOrderHeader).Column("SalesOrderID");
			References(x => x.Product).Column("ProductID");
			Map(x => x.OrderQty).Column("OrderQty").Not.Nullable();
			Map(x => x.UnitPrice).Column("UnitPrice").Not.Nullable();
			Map(x => x.UnitPriceDiscount).Column("UnitPriceDiscount").Not.Nullable();
			Map(x => x.LineTotal).Column("LineTotal").Not.Nullable();
			Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique().Generated.Insert();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
