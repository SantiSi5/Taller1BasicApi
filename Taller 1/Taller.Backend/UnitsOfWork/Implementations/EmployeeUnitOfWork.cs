using Taller.Backend.Repositories.Interfaces;
using Taller.Backend.UnitsOfWork.Interfaces;
using Taller.Shared.Entities;
using Taller.Shared.Responses;

namespace Taller.Backend.UnitsOfWork.Implementations;

public class EmployeeUnitOfWork : GenericUnitOfWork<Employee>, IEmployeeUnitOfWork
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeUnitOfWork(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<ActionResponse<IEnumerable<Employee>>> GetByCoincidenceAsync(string coincidence)
    {
        return await _employeeRepository.GetByCoincidenceAsync(coincidence);
    }
}