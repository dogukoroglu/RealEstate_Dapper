using RealEstate_Dapper.DTOs.ProductDtos;

namespace RealEstate_Dapper.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<GetProductByIdDto> GetProductByIdAsync(int id);

        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
    }
}
