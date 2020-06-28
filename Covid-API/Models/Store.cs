using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace Covid_API.Models
{
    [FirestoreData]
    public class Store
    {
        [FirestoreProperty]
        public string cnpjStore { get; set; }
        
        [FirestoreProperty]
        public List<Product> products { get; set; }

        [FirestoreProperty]
        public GeoPoint location { get; set; }
    }
}
