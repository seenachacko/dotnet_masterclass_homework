using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealController : ControllerBase{
  private IMealRepository _repo;
  public MealController(IMealRepository repo){
      _repo=repo;
  }
    [HttpGet("ListAllMeals")]
    public async Task <List<Meal>> ListAllMeals(){
        return (await _repo.ListOfMeals()).ToList();
    }
    [HttpPost("AddMeal")]
    public async Task AddMeal([FromBody] Meal meal){
        await _repo.AddMeal(meal);
    }
    [HttpGet("FindMealById")]
    public async Task <Meal> FindMealById (int id){
        return await _repo.FindMealById(id);
    }

    [HttpDelete("DeleteMeal")]
    public async Task DeleteMeal(int id){
       await  _repo.DeleteMeal(id);
    }
}