using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("users")]

public class UserController : ControllerBase{
  private IUserRepository _repo;
  public UserController(IUserRepository repo){
      _repo=repo;
  }
    [HttpGet("ListAllUsers")]
    public async Task <List<User>> ListAllUser(){
        return (await _repo.ListOfUsers()).ToList();
    }
    [HttpPost("AddUser")]
    public async Task AddUser([FromBody] User user){
        await _repo.AddUser(user);
    }
    [HttpGet("FindUserById")]
    public async Task <User> FindUserById (int id){
        return await _repo.FindUserById(id);
    }

    [HttpDelete("DeleteUser")]
    public async Task DeleteUser(int id){
       await  _repo.DeleteUser(id);
    }
}