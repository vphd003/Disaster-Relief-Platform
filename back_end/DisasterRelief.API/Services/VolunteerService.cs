using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class VolunteerService
        : BaseService<Volunteer>, IVolunteerService
    {
        private readonly IVolunteerRepository _repository;

        public VolunteerService(IVolunteerRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Volunteer>> GetApprovedAsync()
        {
            return await _repository.GetApprovedAsync();
        }

        public async Task<IEnumerable<Volunteer>> GetAvailableAsync()
        {
            return await _repository.GetAvailableAsync();
        }
    }
}