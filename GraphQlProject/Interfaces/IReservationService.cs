using GraphQlProject.Models;

namespace GraphQlProject.Interfaces
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}