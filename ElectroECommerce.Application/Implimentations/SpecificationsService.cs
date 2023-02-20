using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class SpecificationsService : ISpecificationsService
    {
        private readonly ISpecificationsRepository _specificationsRepository;
        public SpecificationsService(ISpecificationsRepository specificationsRepository)
        {
            _specificationsRepository = specificationsRepository;
        }
        public async Task<Specifications> GetSpecificationsByIdAsync(int id)
        {
            return await _specificationsRepository.GetAsync(id);
        }

        public async Task<Specifications> UpdateSpecificationsAsync(Specifications specifications)
        {
            if (specifications != null)
            {
                var specUpdate = await GetSpecificationsByIdAsync(specifications.Id);
                if (specUpdate != null)
                {
                    specUpdate.CPU = specifications.CPU;
                    specUpdate.RAM = specifications.RAM;
                    specUpdate.Storage = specifications.Storage;
                    specUpdate.MonitorSize = specifications.MonitorSize;
                    specUpdate.Weight = specifications.Weight;
                    specUpdate.VGA = specifications.VGA;
                    specUpdate.CreatedBy = specifications.CreatedBy;
                    specUpdate.UpdatedBy = specifications.UpdatedBy;
                    specUpdate.Status = specifications.Status;
                    return await _specificationsRepository.UpdateAsync(specUpdate);
                }
            }
            return null;
        }

        public async Task<Specifications> CreateSpecificationsAsync(Specifications specifications)
        {
            if (specifications == null)
            {
                return null;
            }
            return await _specificationsRepository.CreateAsync(specifications);
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
