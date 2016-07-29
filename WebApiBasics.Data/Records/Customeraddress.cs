using System;

namespace WebApiBasics.Data.Records
{
    public class CustomerAddress
    {
        public virtual int CustomerId { get; set; }
        public virtual int AddressId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Address Address { get; set; }
        public virtual string AddressType { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as CustomerAddress;
			if (t == null) return false;
			if (CustomerId == t.CustomerId
			 && AddressId == t.AddressId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ CustomerId.GetHashCode();
			hash = (hash * 397) ^ AddressId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
