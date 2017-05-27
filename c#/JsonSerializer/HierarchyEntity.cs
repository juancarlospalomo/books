using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace JsonSerializer
{

    [DataContractAttribute]
    public class HierarchyEntity
    {
        [DataMemberAttribute(Name = "title", Order = 1)]
        public string name { get; set; }

        [DataMemberAttribute(Name = "childrens", Order = 2)]
        public List<SimpleEntity> childrens { get; set; }

        [DataMemberAttribute(Name = "ingredients_array", Order = 3)]
        private string[] ingredients_array;

        public List<Ingredient> ingredients
        {
            get
            {
                var ingredientList = new List<Ingredient>();
                foreach (string value in ingredients_array)
                {
                    ingredientList.Add(new Ingredient() { name = value });
                }
                return ingredientList;
            }
            set
            {
                ingredients_array = new string[value.Count];
                int index = 0;
                foreach (Ingredient ingredient in value)
                {
                    ingredients_array[index] = ingredient.name;
                    index++;
                }
            }
        }

        public string Serialize()
        {
            MemoryStream ms = new MemoryStream();
            var serializer = new DataContractJsonSerializer(typeof(HierarchyEntity));

            serializer.WriteObject(ms, this);
            byte[] buffer = ms.ToArray();
            return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
        }

        public void Deserialize(string json)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            ms.Write(buffer, 0, buffer.Length - 1);
            //After writing, the position is at the end of the stream,
            //so, we set the position at the begining for allowing to serializer
            //to read it correctly
            ms.Seek(0, SeekOrigin.Begin);

            var serializer = new DataContractJsonSerializer(typeof(HierarchyEntity));
            var hierarchyEntity = serializer.ReadObject(ms) as HierarchyEntity;

            this.name = hierarchyEntity.name;
            this.childrens = new List<SimpleEntity>();
            foreach (SimpleEntity entity in hierarchyEntity.childrens)
            {
                this.childrens.Add(entity);
            }
            this.ingredients_array = hierarchyEntity.ingredients_array;

            ms.Dispose();
            hierarchyEntity = null;
        }
    }

}