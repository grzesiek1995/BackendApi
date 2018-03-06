using System;
using Api.Infrastructure.DTO;

namespace Api.Infrastructure.Services
{
    public interface IDriverService
    {
        DriverDto Get(Guid userId);
    }
}