using System;
using System.Collections.Generic;

namespace JsonSerializer
{

    class Program
    {

        private static void SerializeSimpleEntity()
        {
            var entity = new SimpleEntity() { id = "myid" };
            var result = entity.serialize();
            Console.WriteLine($"simple entity json: {result}");

            var entity1 = new SimpleEntity();
            entity1.deserialize(result);

            Console.WriteLine($"simple entity properties: {entity1.id}");
        }

        private static void SerializeHierarchyEntity()
        {
            var childrens = new List<SimpleEntity>();
            childrens.Add(new SimpleEntity() { id = "simple 1" });
            childrens.Add(new SimpleEntity() { id = "simple 2" });

            var ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { name = "rice" });
            ingredients.Add(new Ingredient() { name = "carrot" });

            var entity = new HierarchyEntity()
            {
                name = "hierarchy name",
                childrens = childrens,
                ingredients = ingredients
            };

            var result = entity.Serialize();
            Console.WriteLine($"Hierarchy Json: {entity.Serialize()}");

            var entity1 = new HierarchyEntity();
            entity1.Deserialize(result);
            Console.WriteLine($"Title: {entity1.name}");
            Console.WriteLine($"Childrens ------------");
            foreach (SimpleEntity simple in entity1.childrens)
            {
                Console.WriteLine($"id:{simple.id}");
            }
            Console.WriteLine($"Ingredients ------------");
            foreach (Ingredient Ingredient in entity1.ingredients)
            {
                Console.WriteLine($"id:{Ingredient.name}");
            }

        }

        static void Main(string[] args)
        {
            SerializeSimpleEntity();
            SerializeHierarchyEntity();
        }
    }
}
