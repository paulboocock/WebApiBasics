using System;
using System.Collections.Generic;

namespace WebApiBasics.Data.Records
{
    public class ProductDescription
    {
        public virtual int ProductDescriptionId { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IList<ProductModelProductDescription> ProductModelProductDescription { get; set; } = new List<ProductModelProductDescription>();
    }
}
