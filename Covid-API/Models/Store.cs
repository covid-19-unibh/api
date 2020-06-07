using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covid_API.Models
{
    [FirestoreData]
    public class Store
    {
        [FirestoreProperty]
        public string cnpjStore { get; set; }
        
        [FirestoreProperty]
        public List<Product> product { get; set; }

        [FirestoreProperty]
        public GeoPoint location { get; set; }
    }
}
