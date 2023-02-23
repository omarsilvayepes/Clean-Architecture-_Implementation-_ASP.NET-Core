using EmployeeApplication.Commands;
using EmployeeApplication.Mapper;
using EmployeeApplication.Responses;
using EmployeeCore.Interfaces;
using MediatR;

namespace EmployeeApplication.Handlers
{
    public class CreateEmployeeHandler:IRequestHandler<CreateEmployeeCommand,EmployeeResponse>
    {
        private readonly IEmployeeRepository employeeRepository;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity = EmployeeMapper.Mapper.Map<EmployeeCore.Entities.Employee>(request);
            if (employeeEntity == null)
            {
                throw new ApplicationException("Issue with mapper");

            }

            var newEployee=await employeeRepository.CreateAsync(employeeEntity);
            var employeeResponse= EmployeeMapper.Mapper.Map<EmployeeResponse>(newEployee);
            return employeeResponse;
        }
    }
}
