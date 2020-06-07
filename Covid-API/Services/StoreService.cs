using Covid_API.Data;
using Covid_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid_API.Services
{
    public class StoreService
    {
        private readonly CovidData covidData = new CovidData();

        public async Task<Store> GetStore(string docPath)
        {
            return await covidData.GetData<Store>(Utils.Constants.stores, docPath);
        }

        public async Task<IEnumerable<Store>> GetStore()
        {
            return await covidData.GetAllData<Store>(Utils.Constants.stores);
        }

        public async Task AddStore(Store store)
        {
            await covidData.AddStore(store);
        }

        public async Task SetStore(string docPath, Store store)
        {
            await covidData.SetData(Utils.Constants.stores, docPath, store);
        }

        public async Task SetStoreField(string docPath, Store store)
        {
            await covidData.SetDataField(Utils.Constants.stores, docPath, store);
        }

        public async Task DeleteStore(string docPath)
        {
            await covidData.DeleteData(Utils.Constants.stores, docPath);
        }
    }
}
