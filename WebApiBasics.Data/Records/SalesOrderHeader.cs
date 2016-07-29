using System;
using System.Collections.Generic;


namespace WebApiBasics.Data.Records
{
    public class SalesOrderHeader
    {
        public virtual int SalesOrderId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Address ShipToAddress { get; set; }
        public virtual Address BillToAddress { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? ShipDate { get; set; }
        public virtual byte Status { get; set; }
        public virtual bool OnlineOrderFlag { get; set; }
        public virtual string SalesOrderNumber { get; set; }
        public virtual string PurchaseOrderNumber { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string ShipMethod { get; set; }
        public virtual string CreditCardApprovalCode { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmount { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual string Comment { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IList<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();
    }
}
