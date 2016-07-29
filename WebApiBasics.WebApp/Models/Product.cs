using System;

namespace WebApiBasics.WebApp.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProductNumber { get; set; }
        public virtual string Color { get; set; }
        public virtual decimal StandardCost { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual string Size { get; set; }
        public virtual decimal? Weight { get; set; }
        public virtual DateTime SellStartDate { get; set; }
        public virtual DateTime? SellEndDate { get; set; }
        public virtual DateTime? DiscontinuedDate { get; set; }
        public virtual byte[] ThumbNailPhoto { get; set; }
        public virtual string ThumbnailPhotoFileName { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}