using System;
using System.Collections.Generic;

namespace WebApiBasics.Data.Records
{
    public class Customer
    {
        public virtual int CustomerID { get; set; }
        public virtual bool NameStyle { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string SalesPerson { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Phone { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string PasswordSalt { get; set; }
        public virtual Guid RowGuid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual IList<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
        public virtual IList<SalesOrderHeader> SalesOrderHeaders { get; set; } = new List<SalesOrderHeader>();
    }
}
