using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        Reservation AddReservation(Reservation reservation);
        
    }
}
