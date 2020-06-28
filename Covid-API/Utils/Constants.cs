using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace Covid_API.Utils
{
    public static class Constants
    {
        public const string sdCovid = "sd-covid";
        public const string users = "users";
        public const string stores = "stores";
    }

    public class Locations
    {
        public Dictionary<string, GeoPoint> Location
        { 
            get 
            {
                return new Dictionary<string, GeoPoint>()
                {
                    {"Santa Cruz", new GeoPoint(-19.8784496, -43.9448802)},
                    {"Acaiaca", new GeoPoint(-20.362690, -43.143620)},
                    {"Alto Vera Cruz", new GeoPoint(-19.909602, -43.894097)},
                    {"Pompeia", new GeoPoint(-19.9122135, -43.9040913)},
                    {"Lindeia", new GeoPoint(-19.9785545, -44.0532889)},
                    {"Águas Claras", new GeoPoint(-20.0122972, -44.0237676)},
                    {"Zilah Spósito", new GeoPoint(-19.800914, -43.9266177)},
                    {"Vitória", new GeoPoint(-19.8626698, -43.8892491)},
                    {"Vista do Sol", new GeoPoint(-19.8496497, -43.892048)},
                    {"Funcionários", new GeoPoint(-19.931935, -43.9312246)},
                    {"Gameleira", new GeoPoint(-19.932306, -43.987954)},
                    {"Estoril", new GeoPoint(-19.964820, -43.962187)},
                    {"Floresta", new GeoPoint(-19.917150, -43.929410)},
                    {"Gutierrez", new GeoPoint(-19.935738, -43.959289)},
                    {"Havaí", new GeoPoint(-19.954066, -43.976683)},
                    {"Lourdes", new GeoPoint(-19.931062, -43.943268)},
                    {"Sion", new GeoPoint(-19.953092, -43.934122)},
                    {"Serra", new GeoPoint(-19.940302, -43.920040)}
                };
            }
        }
    }
}
