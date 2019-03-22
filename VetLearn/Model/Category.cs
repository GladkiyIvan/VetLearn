using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VetLearn.Model
{
    class Category : ICategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }

        public Category(string name)
        {
            Id = name;
            Questions = new List<Question> ();
        }
        public Category()
        { }
    }
}
