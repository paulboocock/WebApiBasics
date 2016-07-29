using System;
using System.Collections.Generic;


namespace WebApiBasics.Data.Records {
    
    public class Address {
        public virtual int AddressID { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string StateProvince { get; set; }
        public virtual string CountryRegion { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual System.Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IList<CustomerAddress> CustomerAddress { get; set; } = new List<CustomerAddress>();
        public virtual IList<SalesOrderHeader> BillingSalesOrderHeaders { get; set; } = new List<SalesOrderHeader>();
        public virtual IList<SalesOrderHeader> ShippingSalesOrderHeaders { get; set; } = new List<SalesOrderHeader>();
    }
}
