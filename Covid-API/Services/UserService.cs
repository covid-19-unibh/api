using Covid_API.Data;
using Covid_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid_API.Services
{
    public class UserService
    {
        private readonly CovidData covidData = new CovidData();

        public async Task<User> GetUser(string docPath)
        {
            return await covidData.GetData<User>(Utils.Constants.users, docPath);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await covidData.GetAllData<User>(Utils.Constants.users);
        }

        public async Task AddUser(User user)
        {
            await covidData.AddUser(user);
        }

        public async Task SetUser(string docPath, User user)
        {
            await covidData.SetData(Utils.Constants.users, docPath, user);
        }

        public async Task SetUserField(string docPath, User user)
        {
            await covidData.SetDataField(Utils.Constants.users, docPath, user);
        }

        public async Task DeleteUser(string docPath)
        {
            await covidData.DeleteData(Utils.Constants.users, docPath);
        }
    }
}
