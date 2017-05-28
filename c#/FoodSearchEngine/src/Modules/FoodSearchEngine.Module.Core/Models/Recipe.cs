using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

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

        [DataMemberAttribute(Name = "ingredients")]
        private string[] ingredientsArray { get; set; }

        [IgnoreDataMember]
        public List<Ingredient> Ingredients
        {
            get
            {
                var ingredientList = new List<Ingredient>();
                foreach (string value in ingredientsArray)
                {
                    ingredientList.Add(new Ingredient() { name = value });
                }

                return ingredientList;
            }
        }

    }

}