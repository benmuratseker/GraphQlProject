using GraphQL.Types;
using GraphQlProject.Models;

namespace GraphQlProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.TotalPeople);
            Field(m => m.Email);
            Field(m => m.Phone);
            Field(m => m.Date);
            Field(m => m.Time);
        }
    }
}