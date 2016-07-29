using System;

namespace WebApiBasics.Data.Records
{
    public class SalesOrderDetail
    {
        public virtual int SalesOrderId { get; set; }
        public virtual int SalesOrderDetailId { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public virtual Product Product { get; set; }
        public virtual short OrderQty { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal UnitPriceDiscount { get; set; }
        public virtual double LineTotal { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as SalesOrderDetail;
			if (t == null) return false;
			if (SalesOrderId == t.SalesOrderId
			 && SalesOrderDetailId == t.SalesOrderDetailId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ SalesOrderId.GetHashCode();
			hash = (hash * 397) ^ SalesOrderDetailId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
