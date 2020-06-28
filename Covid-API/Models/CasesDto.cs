using Google.Cloud.Firestore;

namespace Covid_API.Models
{
    public class CasesDto
    {
        public string ObjectId { get; set; }
        public string Neighborhood { get; set; }
        public GeoPoint Location { get; set; }
        public int Serious { get; set; }
        public int NonSerious { get; set; }
        public int Deaths { get; set; }
    }
}
