using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace FoodSearchEngine.Module.Core.Models
{

    [DataContractAttribute]
    public class RecipesResult
    {
        [DataMemberAttribute(Name = "count")]
        public int count { get; set; }

        [DataMemberAttribute(Name = "recipes")]
        public List<Recipe> recipes { get; set; }

        [DataMemberAttribute(Name = "recipe")]
        public Recipe current { get; set; }

        public bool CanBeDeserialized(string json)
        {
            bool canBe = false;

            var stream = new System.IO.MemoryStream();
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(json);
            stream.Read(buffer, 0, buffer.Length);

            var serializer = new DataContractJsonSerializer(typeof(RecipesResult));
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            
            var result = serializer.ReadObject(stream) as RecipesResult;
            if ((result != null && result.current != null) ||
                    (result != null && result.recipes != null))
            {
                canBe = true;
            }

            return canBe;
        }

    }
}

