namespace MealsharingNET.Services;
using System.Collections.Generic;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;
using Dapper;

public class UserRepository : IUserRepository{
public async Task<IEnumerable<User>> ListOfUsers()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var users = await connection.QueryAsync<User>("SELECT id,name as Name,email as Email,phone as Phone FROM user");

        return users;
        
    }
 public async Task AddUser(User user){
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var userId = await connection.ExecuteAsync("INSERT INTO user(name,email,phone) VALUES (@Name,@Email,@Phone) ", user);
    }

    public async Task<User> FindUserById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var user = await connection.QueryFirstAsync<User>("SELECT id,name as Name,email as Email,phone as Phone FROM user WHERE id=@ID", new { ID = id });
        return user;
        
    }

public async Task DeleteUser(int id){
        await using var connection=new MySqlConnection(Shared.ConnectionString);
        var userId = await connection.ExecuteAsync("DELETE FROM user WHERE id=@ID", new { ID = id });

    }

}