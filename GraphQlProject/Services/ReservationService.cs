using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Services
{
    public class ReservationService : IReservationService
    {
        private readonly GraphQlDbContext dbContext;

        public ReservationService(GraphQlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            dbContext.Reservations.Add(reservation);
            dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return dbContext.Reservations.ToList();
        }
    }
}