using Store_Procedure_Demo.Entities;

namespace Store_Procedure_Demo.Repositories
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductListAsync();
        public Task<IEnumerable<Product>> GetProductByIdAsync(int Id);
        public Task<int> AddProductAsync(Product product);
        public Task<int> UpdateProductAsync(Product product);
        public Task<int> DeleteProductAsync(int Id);
    }
}
