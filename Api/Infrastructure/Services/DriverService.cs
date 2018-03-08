using System;
using System.Threading.Tasks;
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
        public async  Task<DriverDto> GetAsync(Guid userId)
        {
           var driver = await _driverRepository.GetAsync(userId);

            return _mapper.Map<Driver,DriverDto>(driver);
        }
    }
}