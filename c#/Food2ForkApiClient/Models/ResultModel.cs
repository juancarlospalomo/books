using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Food2ForkApiClient
{

    [DataContractAttribute]
    public class ResultModel
    {
        [DataMemberAttribute(Name = "count")]
        public int count { get; set; }

        [DataMemberAttribute(Name = "recipes")]
        public List<Recipe> recipes { get; set; }

    }
}