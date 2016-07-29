using System;

namespace WebApiBasics.Data.Records
{
    public class ProductModelProductDescription
    {
        public virtual int ProductModelId { get; set; }
        public virtual int ProductDescriptionId { get; set; }
        public virtual string Culture { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductDescription ProductDescription { get; set; }
        public virtual System.Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductModelProductDescription;
			if (t == null) return false;
			if (ProductModelId == t.ProductModelId
			 && ProductDescriptionId == t.ProductDescriptionId
			 && Culture == t.Culture)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductModelId.GetHashCode();
			hash = (hash * 397) ^ ProductDescriptionId.GetHashCode();
			hash = (hash * 397) ^ Culture.GetHashCode();

			return hash;
        }
        #endregion
    }
}
