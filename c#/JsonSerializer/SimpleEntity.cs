using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace JsonSerializer
{
    [DataContractAttribute]
    public class SimpleEntity
    {
        [DataMemberAttribute(Name = "simple_id")]
        public string id { get; set; }

        public string serialize()
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SimpleEntity));

            serializer.WriteObject(ms, this);
            byte[] json = ms.ToArray();
            ms.Dispose();

            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        public void deserialize(string json)
        {

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SimpleEntity));

            var result = serializer.ReadObject(ms) as SimpleEntity;
            ms.Dispose();

            this.id = result.id;
        }

    }

}