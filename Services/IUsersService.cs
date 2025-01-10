using AspNetCoreIntro2024.Models;

namespace AspNetCoreIntro2024.Services
{
    public interface IUsersService
    {
        IEnumerable<UserModel> GetUsers();
        UserModel? GetUserById(int id);
    }
}
