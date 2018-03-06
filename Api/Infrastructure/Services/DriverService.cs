using System;
using Api.Core.Domain;
using Api.Core.Repositories;
using Api.Infrastructure.DTO;
using AutoMapper;

namespace Api.Infrastructure.Services
{
    public class DriverService: IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IMapper _mapper;
        public DriverService(IDriverRepository driverRepository, IMapper mapper)
        {
            _mapper = mapper;
            _driverRepository = driverRepository;
        }
        public DriverDto Get(Guid userId)
        {
           var driver =_driverRepository.Get(userId);

            return _mapper.Map<Driver,DriverDto>(driver);
        }
    }
}