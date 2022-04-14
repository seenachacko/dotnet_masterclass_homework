using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("api/reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;
    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }
    [HttpGet("")]
    public async Task<IEnumerable<Reservation>> ListAllReservations()
    {
        return (await _repo.ReservationList()).ToList();
    }
    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservation reservation)
    {
        await _repo.AddReservation(reservation);
    }
    [HttpGet("{id}")]
    public async Task<Reservation> FindReservationById(int id)
    {
        return await _repo.FindReservationById(id);
    }
    [HttpGet("meal/{id}")]

    public async Task<IEnumerable<Reservation>> FindResrvationByMealId(int mealId)
    {
        return await _repo.FindResrvationByMealId(mealId);
    }

    [HttpDelete("{id}")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }

}