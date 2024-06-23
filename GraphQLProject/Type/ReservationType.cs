using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(r => r.Id);
            Field(r => r.CustomerName);
            Field(r => r.PhoneNumber);
            Field(r => r.PartySize);
            Field(r => r.Email);
            Field(r => r.ReservationDate);
            Field(r => r.SpecialRequest);
        }
    }
}
