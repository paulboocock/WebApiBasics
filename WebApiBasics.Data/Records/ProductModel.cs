using System;
using System.Collections.Generic;


namespace WebApiBasics.Data.Records
{
    public class ProductModel
    {
        public virtual int ProductModelId { get; set; }
        public virtual string Name { get; set; }
        public virtual string CatalogDescription { get; set; }
        public virtual System.Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IList<Product> Product { get; set; } = new List<Product>();
        public virtual IList<ProductModelProductDescription> ProductModelProductDescription { get; set; } = new List<ProductModelProductDescription>();
    }
}
