using Covid_API.Data;
using Covid_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid_API.Services
{
    public class UserService
    {
        private readonly FireStoreData fireStoreData = new FireStoreData();

        public async Task<User> GetUser(string docPath)
        {
            return await fireStoreData.GetData<User>(Utils.Constants.users, docPath);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await fireStoreData.GetAllData<User>(Utils.Constants.users);
        }

        public async Task AddUser(User user)
        {
            await fireStoreData.AddUser(user);
        }

        public async Task SetUser(string docPath, User user)
        {
            await fireStoreData.SetData(Utils.Constants.users, docPath, user);
        }

        public async Task SetUserField(string docPath, User user)
        {
            await fireStoreData.SetDataField(Utils.Constants.users, docPath, user);
        }

        public async Task DeleteUser(string docPath)
        {
            await fireStoreData.DeleteData(Utils.Constants.users, docPath);
        }
    }
}
