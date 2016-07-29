using System;
using System.Collections.Generic;

namespace WebApiBasics.Data.Records
{
    public class ProductCategory
    {
        public virtual int ProductCategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IList<Product> Products { get; set; } = new List<Product>();
        public virtual ProductCategory ParentProductCategory { get; set; }
        public virtual IList<ProductCategory> ChildrenProductCategories { get; set; } = new List<ProductCategory>();
    }
}
