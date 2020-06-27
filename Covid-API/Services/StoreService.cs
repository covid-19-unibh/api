using Covid_API.Data;
using Covid_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid_API.Services
{
    public class StoreService
    {
        private readonly FireStoreData fireStoreData = new FireStoreData();

        public async Task<Store> GetStore(string docPath)
        {
            return await fireStoreData.GetData<Store>(Utils.Constants.stores, docPath);
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            return await fireStoreData.GetAllData<Store>(Utils.Constants.stores);
        }

        public async Task AddStore(Store store)
        {
            await fireStoreData.AddStore(store);
        }

        public async Task SetStore(string docPath, Store store)
        {
            await fireStoreData.SetData(Utils.Constants.stores, docPath, store);
        }

        public async Task SetStoreField(string docPath, Store store)
        {
            await fireStoreData.SetDataField(Utils.Constants.stores, docPath, store);
        }

        public async Task DeleteStore(string docPath)
        {
            await fireStoreData.DeleteData(Utils.Constants.stores, docPath);
        }
    }
}
