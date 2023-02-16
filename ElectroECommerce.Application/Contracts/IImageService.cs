using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IImageService
    {
        Task<Image> GetImageByIdAsync(int id);

        Task<Image> CreateImageAsync(Image image);

        Task<Image> UpdateImageAsync(Image image);

        Task DeleteImageAsync(int id);
    }
}
