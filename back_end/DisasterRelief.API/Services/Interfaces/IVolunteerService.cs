using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface IVolunteerService : IBaseService<Volunteer>
    {
        Task<IEnumerable<Volunteer>> GetApprovedAsync();

        Task<IEnumerable<Volunteer>> GetAvailableAsync();
    }
}