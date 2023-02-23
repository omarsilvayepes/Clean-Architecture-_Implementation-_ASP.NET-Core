using AutoMapper;
using EmployeeApplication.Commands;
using EmployeeApplication.Responses;

namespace EmployeeApplication.Mapper
{
    public  class EmployeeMappingProfile:Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<EmployeeCore.Entities.Employee,EmployeeResponse>().ReverseMap();
            CreateMap<EmployeeCore.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
