using Google.Cloud.Firestore;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_API.Models.MongoDB
{
    public class Cases
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; }
        public string neighborhood { get; set; }
        //public GeoPoint Location { get; set; }
        public int serious { get; set; }
        public int nonSerious { get; set; }
        public int deaths { get; set; }
    }
}
