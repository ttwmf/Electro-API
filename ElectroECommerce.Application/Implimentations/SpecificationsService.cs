using AutoMapper;
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class SpecificationsService : ISpecificationsService
    {
        private readonly ISpecificationsRepository _specificationsRepository;
        private readonly IMapper _mapper;
        public SpecificationsService(ISpecificationsRepository specificationsRepository, IMapper mapper)
        {
            _specificationsRepository = specificationsRepository;
            _mapper = mapper;
        }
        public async Task<Specifications> GetSpecificationsByIdAsync(int id)
        {
            return await _specificationsRepository.GetAsync(id);
        }

        public async Task<Specifications> UpdateSpecificationsAsync(int id, UpdateSpecificationsRequest updateSpecificationslRequest)
        {
            var updateSpecifications = await _specificationsRepository.GetAsync(id);
            if (updateSpecifications != null)
            {
                updateSpecifications.Weight = updateSpecificationslRequest.Weight;
                updateSpecifications.MonitorSize = updateSpecificationslRequest.MonitorSize;
                updateSpecifications.Storage = updateSpecificationslRequest.Storage;
                updateSpecifications.VGA = updateSpecificationslRequest.VGA;
                updateSpecifications.RAM = updateSpecificationslRequest.RAM;
                updateSpecifications.CPU = updateSpecificationslRequest.CPU;
            }
            return await _specificationsRepository.UpdateAsync(updateSpecifications);
        }

        public async Task<Specifications> CreateSpecificationsAsync(CreateSpecificationsRequest specifications)
        {
            var newSpecifications = _mapper.Map<CreateSpecificationsRequest, Specifications>(specifications);

            return await _specificationsRepository.CreateAsync(newSpecifications);
        }

            public async Task DeleteSpecificationsAsync(int id)
        {
            var specifications = await _specificationsRepository.GetAsync(id);
            if (specifications != null)
            {
                await _specificationsRepository.DeleteAsync(specifications);
            }
        }

        public async Task<IEnumerable<Specifications>> GetSpecificationsAsync()
        {
            return await _specificationsRepository.GetAllAsync();
        }
    }
}
