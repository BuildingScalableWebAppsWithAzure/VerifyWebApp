using System;
using System.Collections.Generic;

namespace Verify.Models
{
    public partial class Person
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsDeceased { get; set; }
    }
}
