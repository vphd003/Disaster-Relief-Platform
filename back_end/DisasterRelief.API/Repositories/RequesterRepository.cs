using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Repositories
{
    public class RequesterRepository
        : GenericRepository<Requester>, IRequesterRepository
    {
        public RequesterRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}