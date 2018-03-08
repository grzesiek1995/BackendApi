using System;
using System.Threading.Tasks;
using Api.Infrastructure.DTO;

namespace Api.Infrastructure.Services
{
    public interface IDriverService
    {
       Task< DriverDto> GetAsync(Guid userId);
    }
}