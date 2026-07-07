using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class RequesterService
        : BaseService<Requester>, IRequesterService
    {
        public RequesterService(IRequesterRepository repository)
            : base(repository)
        {
        }
    }
}