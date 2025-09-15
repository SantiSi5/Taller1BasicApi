using Taller.Shared.Entities;
using Taller.Shared.Responses;

namespace Taller.Backend.Repositories.Interfaces;

public interface IEmployeeRepository : IGenericRepository<Employee>
{
    Task<ActionResponse<IEnumerable<Employee>>> GetByCoincidenceAsync(string coincidence);
}