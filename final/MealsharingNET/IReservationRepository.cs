using MealsharingNET.Models;
namespace MealsharingNET;

public interface IReservationRepository
{
    Task<IEnumerable<Reservation>> ReservationList();
    Task AddReservation(Reservation reservation);

    Task<Reservation> FindReservationById(int id);

    Task<IEnumerable<Reservation>> FindResrvationByMealId(int mealId);
    Task DeleteReservation(int id);
}