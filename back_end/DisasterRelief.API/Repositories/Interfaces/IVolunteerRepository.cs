using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface IVolunteerRepository
        : IGenericRepository<Volunteer>
    {
        Task<IEnumerable<Volunteer>> GetApprovedAsync();

        Task<IEnumerable<Volunteer>> GetAvailableAsync();
    }
}