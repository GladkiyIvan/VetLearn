using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VetLearn.Model
{
    public class Question : IQuestion
    {
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("answer")]
        public string Answer { get; set; }
        [JsonProperty("image_path")]
        public string ImagePath { get; set; }
        [JsonIgnore]
        public Image Image { get; set; }

        public Question(string categoryId, string description, string answer, string imagePath)
        {
            CategoryId = categoryId;
            Description = description;
            Answer = answer;
            ImagePath = imagePath;
        }

        public Question() { }
    }
}
