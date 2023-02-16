
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/image")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Image>> GetImageByIdAsync(int id)
        {
            try
            {
                var result = await _imageService.GetImageByIdAsync(id);
                if (result == null)
                    return NotFound("Image no existed");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Image>> CreateImageAsync(Image image)
        {
            try
            {
                var result = await _imageService.CreateImageAsync(image);
                if (result == null)
                    return BadRequest("Object image is null");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Image>> UpdateImageAsync(int id, Image image)
        {
            try
            {
                Image imageIsvalid = await _imageService.GetImageByIdAsync(id);
                if (imageIsvalid == null)
                {
                    return BadRequest("Id = " + id + " not found in Database");
                }
                else
                {
                    image.Id= imageIsvalid.Id;
                    var result = await _imageService.UpdateImageAsync(image);
                    return Ok(result);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteImageAsync(int id)
        {
            try
            {
                var isValid = await GetImageByIdAsync(id);
                if (isValid == null)
                    return NotFound("Image no existed");
                await _imageService.DeleteImageAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
