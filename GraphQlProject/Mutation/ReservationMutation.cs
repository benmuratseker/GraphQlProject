using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using GraphQlProject.Type;

namespace GraphQlProject.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationService reservationService)
        {
            Field<ReservationType>(name: "createReservation", arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }), resolve: context =>
            {
                return reservationService.AddReservation(context.GetArgument<Reservation>("reservation"));
            });
        }
    }
}