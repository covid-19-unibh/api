using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_API.Models
{
    [FirestoreData]
    public class Product
    {
        [FirestoreProperty]
        public string name { get; set; }
        [FirestoreProperty]
        public string category { get; set; }
        [FirestoreProperty]
        public int quantity { get; set; }
    }
}
