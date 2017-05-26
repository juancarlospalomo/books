using System;
using System.Runtime.Serialization;

namespace FoodSearchEngine.Module.Core.Models
{

    [DataContractAttribute]
    public class Recipe : Entity
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
        public string rank { get; set; }

        [DataMemberAttribute(Name = "image_url")]
        public string imageUrl { get; set; }

/*        [DataMemberAttribute(Name = "ingredients")]
        private string ingredientsName { get; set; }*/
    }

}