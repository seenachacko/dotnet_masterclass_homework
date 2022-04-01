namespace MealsharingNET.Services;
using System.Collections.Generic;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;
using Dapper;
public class ReservationRepository : IReservationRepository{

 public async Task<IEnumerable<Reservation>> ReservationList()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservationsList = await connection.QueryAsync<Reservation>("SELECT id, meal_id as MealID, name as Name,email as Email,created_date as Date,number_of_guests as NoOfPersons  FROM reservation");
        
        return reservationsList;
    }
    public async Task AddReservation(Reservation reservation){
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservationId = await connection.ExecuteAsync("INSERT INTO reservation(meal_id,name,email,created_date,number_of_guests) VALUES (@MealID,@Name,@Email,@Date,@NoOfPersons) ", reservation);
    }
   public async Task<Reservation> FindReservationById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservation = await connection.QueryFirstAsync<Reservation>("SELECT id, meal_id as MealID, name as Name,email as Email,created_date as Date,number_of_guests as NoOfPersons  FROM reservation WHERE id=@id", new { id });
        return reservation;
    }
    public async Task<IEnumerable<Reservation>> FindResrvationByMealId(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservation>("SELECT id, meal_id as MealID, name as Name,email as Email,created_date as Date,number_of_guests as NoOfPersons  FROM reservation WHERE meal_id=@id", new { id });
        return reservations;
    }
    public async Task DeleteReservation(int id){
        await using var connection=new MySqlConnection(Shared.ConnectionString);
        var resevationId = await connection.ExecuteAsync("DELETE FROM reservation WHERE id=@id", new { id });

    }
}