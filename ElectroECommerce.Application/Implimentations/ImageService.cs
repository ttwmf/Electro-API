using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
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

        public async Task<Image> CreateImageAsync(Image image)
        {
            if (image == null)
            {
                return null;
            }
            return await _imageRepository.CreateAsync(image);
        }

        public async Task<Image> UpdateImageAsync(Image image)
        {
            if (image != null)
            {   
                var imageUpdate = await GetImageByIdAsync(image.Id);
                if (imageUpdate != null)
                {
                    imageUpdate.ImageName = image.ImageName;
                    imageUpdate.ImageUrl = image.ImageUrl;
                    imageUpdate.CreatedBy = image.CreatedBy;
                    imageUpdate.UpdatedBy = image.UpdatedBy;
                    imageUpdate.Status = image.Status;
                    return await _imageRepository.UpdateAsync(imageUpdate);
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
