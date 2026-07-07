using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;
using DisasterReliefAPI.Repositories.Interfaces;

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