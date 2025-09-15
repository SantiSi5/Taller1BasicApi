using Taller.Shared.Entities;
using Taller.Shared.Responses;

namespace Taller.Backend.UnitsOfWork.Interfaces;

public interface IEmployeeUnitOfWork : IGenericUnitOfWork<Employee>
{
    Task<ActionResponse<IEnumerable<Employee>>> GetByCoincidenceAsync(string coincidence);
}