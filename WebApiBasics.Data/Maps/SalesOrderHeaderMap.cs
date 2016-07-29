using FluentNHibernate.Mapping;
using WebApiBasics.Data.Records; 

namespace WebApiBasics.Data.Maps
{
    public class SalesOrderHeaderMap : ClassMap<SalesOrderHeader>
    {
        public SalesOrderHeaderMap()
        {
            Table("SalesLT.SalesOrderHeader");
            Id(x => x.SalesOrderId).GeneratedBy.Identity().Column("SalesOrderID");
            References(x => x.Customer).Column("CustomerID");
            References(x => x.ShipToAddress).Column("ShipToAddressID");
            References(x => x.BillToAddress).Column("BillToAddressID");
            Map(x => x.RevisionNumber).Column("RevisionNumber").Not.Nullable();
            Map(x => x.OrderDate).Column("OrderDate").Not.Nullable();
            Map(x => x.DueDate).Column("DueDate").Not.Nullable();
            Map(x => x.ShipDate).Column("ShipDate");
            Map(x => x.Status).Column("Status").Not.Nullable();
            Map(x => x.OnlineOrderFlag).Column("OnlineOrderFlag").Not.Nullable();
            Map(x => x.SalesOrderNumber).Column("SalesOrderNumber").Not.Nullable().Unique();
            Map(x => x.PurchaseOrderNumber).Column("PurchaseOrderNumber");
            Map(x => x.AccountNumber).Column("AccountNumber");
            Map(x => x.ShipMethod).Column("ShipMethod").Not.Nullable();
            Map(x => x.CreditCardApprovalCode).Column("CreditCardApprovalCode");
            Map(x => x.SubTotal).Column("SubTotal").Not.Nullable();
            Map(x => x.TaxAmount).Column("TaxAmt").Not.Nullable();
            Map(x => x.Freight).Column("Freight").Not.Nullable();
            Map(x => x.TotalDue).Column("TotalDue").Not.Nullable();
            Map(x => x.Comment).Column("Comment");
            Map(x => x.RowGuid).Column("rowguid").Not.Nullable().Unique();
            Map(x => x.ModifiedDate).Column("ModifiedDate").Not.Nullable();
            HasMany(x => x.SalesOrderDetails).KeyColumn("SalesOrderID");
        }
    }
}
