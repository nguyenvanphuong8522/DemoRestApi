﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace DemoRestApi3.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? CategoryName { get; set; }
    }
}
