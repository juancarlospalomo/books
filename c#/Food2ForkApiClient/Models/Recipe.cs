using System;
using System.Runtime.Serialization;

namespace Food2ForkApiClient
{
    [DataContractAttribute]
    public class Recipe
    {
        [DataMemberAttribute(Name = "recipe_id")]
        public string id { get; set; }

        [DataMemberAttribute(Name = "publisher")]
        public string publisherName { get; set; }

        [DataMemberAttribute(Name = "title")]
        public string title { get; set; }

        [DataMemberAttribute(Name = "source_url")]
        public string url { get; set; }

        [DataMemberAttribute(Name = "social_rank")]
        public double rank { get; set; }

        [DataMemberAttribute(Name = "image_url")]
        public string imageUrl { get; set; }

    }

}
