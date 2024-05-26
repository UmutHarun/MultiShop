using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImagesAsync();
        Task<GetProductImageByIdDto> GetProductImageAsync(string id);
        Task CreateProductImageAsync(CreateProductImageDto productDto);
        Task UpdateProductImageAsync(UpdateProductImageDto productDto);
        Task DeleteProductImageAsync(string id);
    }
}
