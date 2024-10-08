using RealEstate_Dapper.DTOs.CategoryDtos;

namespace RealEstate_Dapper.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto categoryDto);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
    }
}
