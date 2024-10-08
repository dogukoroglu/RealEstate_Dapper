using Dapper;
using RealEstate_Dapper.DTOs.ProductDtos;
using RealEstate_Dapper.Models.DapperContext;

namespace RealEstate_Dapper.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "select * from product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync()
        {
            string query = "select ProductID,ProductTitle,ProductPrice,ProductCity,ProductDistrict,CategoryName from product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public Task<GetProductByIdDto> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
