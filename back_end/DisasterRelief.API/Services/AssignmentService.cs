using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;

namespace DisasterReliefAPI.Services
{
    public class AssignmentService
        : BaseService<Assignment>, IAssignmentService
    {
        public AssignmentService(IAssignmentRepository repository)
            : base(repository)
        {
        }
    }
}