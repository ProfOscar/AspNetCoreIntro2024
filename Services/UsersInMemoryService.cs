using AspNetCoreIntro2024.Models;

namespace AspNetCoreIntro2024.Services
{
    public class UsersInMemoryService : IUsersService
    {
        private List<UserModel> users = new List<UserModel>
        {
            new UserModel(1, "Paolino", "Paperino", new DateTime(1934,7,5), "San Francisco"),
            new UserModel(2, "Giuseppe", "Garibaldi", new DateTime(1799,10,15), "Nizza"),
            new UserModel(3, "Camillo", "Cavour", new DateTime(1805,1,11), "Torino"),
            new UserModel(4, "Monica", "Bellucci", new DateTime(1968,9,20), "Bologna")
        };

        public IEnumerable<UserModel> GetUsers()
        {
            return users;
        }

        public UserModel? GetUserById(int id)
        {
            return users.SingleOrDefault(u => u.Id == id);
        }

        public UserModel AddUser(UserModel user)
        {
            user.Id = users.Max(u => u.Id) + 1;
            users.Add(user);
            return user;
        }

        public int DeleteUserById(int id)
        {
            return users.RemoveAll(u => u.Id == id);
        }
    }
}
