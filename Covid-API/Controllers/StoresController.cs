using Covid_API.Models;
using Covid_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoresController : ControllerBase
    {
        private readonly StoreService storeService = new StoreService();

        [HttpGet("{id}")]
        public async Task<Store> GetStock(string id)
        {
            return await storeService.GetStore(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Store>> GetStockList()
        {
            return await storeService.GetStore();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStock(string docPath, Store store)
        {
            await storeService.SetStore(docPath, store);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostStock(Store store)
        {
            store.location = new Google.Cloud.Firestore.GeoPoint(-19.95685, 44.063343);

            await storeService.AddStore(store);
            return CreatedAtAction("GetStock", new { id = store.cnpjStore }, store);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(string docPath)
        {
            await storeService.DeleteStore(docPath);
            return Ok();
        }

    }
}
