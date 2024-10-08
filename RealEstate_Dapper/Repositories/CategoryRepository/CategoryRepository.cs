using Dapper;
using RealEstate_Dapper.DTOs.CategoryDtos;
using RealEstate_Dapper.Models.DapperContext;

namespace RealEstate_Dapper.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCategoryAsync(int id)
        {
            string query = "delete from Category where CategoryID=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id)
        {
            string query = "select * from category where CategoryID=@categoryId";
            var paramaters = new DynamicParameters();
            paramaters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, paramaters);
                return value;
            }
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            string query = "update Category set CategoryName=@categoryName, CategoryStatus=@categoryStatus where CategoryID=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);
            parameters.Add("@categoryId", categoryDto.CategoryID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
