using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using System;
using Covid_API.Models;

namespace Covid_API.Data
{
    public class CovidData
    {
        protected FirestoreDb dataBase;

        public CovidData()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", AppDomain.CurrentDomain.BaseDirectory + Utils.Constants.sdCovid + ".json");
            dataBase = FirestoreDb.Create(Utils.Constants.sdCovid);
        }

        public async Task<T> GetData<T>(string collPath, string docPath)
        {
            DocumentReference docRef = dataBase.Collection(collPath).Document(docPath);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();

            if (snap.Exists)
                return snap.ConvertTo<T>();
            else
                return default;
        }

        public async Task<IEnumerable<T>> GetAllData<T>(string collPath)
        {
            Query qRef = dataBase.Collection(collPath);

            QuerySnapshot qSnap = await qRef.GetSnapshotAsync();

            List<T> list = new List<T>();

            foreach (DocumentSnapshot docSnap in qSnap)
            {
                if (docSnap.Exists)
                    list.Add(docSnap.ConvertTo<T>());
            }

            return list;
        }

        public async Task AddUser(User user)
        {
            CollectionReference coll = dataBase.Collection(Utils.Constants.users);

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "location", user.location },
                { "isSick", user.isSick },
                { "name", user.name }
            };
            await coll.AddAsync(data);
        }

        public async Task AddStore(Store store)
        {
            CollectionReference coll = dataBase.Collection(Utils.Constants.stores);

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "location", store.location },
                { "product", store.product },
                { "cnpjStore", store.cnpjStore }
            };
            await coll.AddAsync(data);
        }

        public async Task SetData(string collPath, string docPath, dynamic obj)
        {
            DocumentReference docRef = dataBase.Collection(collPath).Document(docPath);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "location", obj.location },
                { "isSick", obj.isSick },
                { "name", obj.name }
            };

            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
            if (snap.Exists)
                await docRef.SetAsync(data);
        }

        public async Task SetDataField(string collPath, string docPath, dynamic user)
        {
            DocumentReference docRef = dataBase.Collection(collPath).Document(docPath);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "isSick", user.isSick }
            };

            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
            if (snap.Exists)
                await docRef.UpdateAsync(data);
        }

        public async Task DeleteData(string collPath, string docPath)
        {
            DocumentReference docRef = dataBase.Collection(collPath).Document(docPath);
            await docRef.DeleteAsync();
        }
    }
}
