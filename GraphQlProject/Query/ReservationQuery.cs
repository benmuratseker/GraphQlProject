using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Type;

namespace GraphQlProject.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationService reservationService)
        {
            Field<ListGraphType<ReservationType>>(name: "reservations", resolve: context => { return reservationService.GetReservations(); });
        }
    }
}