using MealsharingNET.Models;
namespace MealsharingNET;

public interface IUserRepository
{
    Task<IEnumerable<User>> ListOfUsers();
    Task AddUser(User user);
    Task<User> FindUserById(int id);
    Task DeleteUser(int id);
}