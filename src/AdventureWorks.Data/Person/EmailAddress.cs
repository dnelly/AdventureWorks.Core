﻿using System;

namespace AdventureWorks.Data.Person
{
    public partial class EmailAddress
    {
        public int BusinessEntityId { get; set; }
        public int EmailAddressId { get; set; }
        public string EmailAddress1 { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Person BusinessEntity { get; set; }
    }
}