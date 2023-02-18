using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IImageService
    {
        Task<Image> GetImageByIdAsync(int id);

        Task<Image> CreateImageAsync(CreateImageRequest image);

        Task<Image> UpdateImageAsync(int id ,UpdateImageRequest image);

        Task DeleteImageAsync(int id);
    }
}
