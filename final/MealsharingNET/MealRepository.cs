using MealsharingNET.Models;
using MySql.Data.MySqlClient;
using Dapper;
namespace MealsharingNET.Services;
public class MealRepository : IMealRepository
{
     public async Task<IEnumerable<Meal>> ListOfMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meal>("SELECT id,title as Title,description as Description,imageurl as ImageUrl,location as Location,`when` as `When`,max_reservations as MaxReservations,cost as Cost FROM meal");

        return meals;
        
    }

    public async Task AddMeal(Meal meal){
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealId = await connection.ExecuteAsync("INSERT INTO meal(title,description,imageurl,location,`when`,max_reservations,cost) VALUES (@Title,@Description,@ImageUrl,@Location,@When,@MaxReservations,@Cost) ", meal);
    }
   public async Task<Meal> FindMealById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("SELECT id,title as Title,description as Description,imageurl as ImageUrl,location as Location,`when` as `When`,max_reservations as MaxReservations,cost as Cost  FROM meal WHERE id=@ID", new { ID = id });
        return meal;
        
    }

    public async Task DeleteMeal(int id){
        await using var connection=new MySqlConnection(Shared.ConnectionString);
        var mealId = await connection.ExecuteAsync("DELETE FROM meal WHERE id=@ID", new { ID = id });

    }
   

}