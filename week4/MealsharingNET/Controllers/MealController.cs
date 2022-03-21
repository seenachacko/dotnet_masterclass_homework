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
    public List<Meal> ListAllMeals(){
        return _repo.ListOfMeals().ToList();
    }
    [HttpPost("AddMeal")]
    public void AddMeal([FromBody] Meal meal){
        _repo.AddMeal(meal);
    }
    [HttpGet("FindMealById")]
    public Meal FindMealById (int id){
        return _repo.FindMealById(id);
    }

}