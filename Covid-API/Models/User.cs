using Google.Cloud.Firestore;

namespace Covid_API.Models
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string userId { get; set; }

        [FirestoreProperty]
        public string name { get; set; }

        [FirestoreProperty]
        public bool isSick { get; set; }

        [FirestoreProperty]
        public GeoPoint location { get; set; }
    }
}
