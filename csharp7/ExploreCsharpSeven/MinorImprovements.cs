using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExploreCsharpSeven
{
    static class MinorImprovements
    {
        public class Person
        {
            [DataMember(Name = "first-name")]
            public string FirstName { get; set; }
            [DataMember(Name ="last-name")]
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
