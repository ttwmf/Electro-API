using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        public async Task<Image> GetImageByIdAsync(int id)
        {
            return await _imageRepository.GetAsync(id);
        }

        public async Task<Image> CreateImageAsync(CreateImageRequest image)
        {
            var newImage = new Image()
            {
                ImageName = image.ImageName,
                ImageUrl = image.ImageUrl,

                //TODO 
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedBy = "Tuan",
                UpdatedBy = "Tuan",
                Status = 0
            };
            return await _imageRepository.CreateAsync(newImage);
        }

        public async Task<Image> UpdateImageAsync(int id, UpdateImageRequest image)
        {
            if (image != null)
            {
                var updateImage = await GetImageByIdAsync(id);
                if (updateImage != null)
                {
                    updateImage.ImageName = image.ImageName;
                    updateImage.ImageUrl = image.ImageUrl;
                    updateImage.UpdatedAt = DateTime.UtcNow;
                    updateImage.UpdatedBy = "Tuan";
                    updateImage.Status = image.Status;
                    return await _imageRepository.UpdateAsync(updateImage);
                }
            }
            return null;
        }
        public async Task DeleteImageAsync(int id)
        {
            var image = await _imageRepository.GetAsync(id);
            if (image != null)
            {
                await _imageRepository.DeleteAsync(image);
            }
        }
    }
}
