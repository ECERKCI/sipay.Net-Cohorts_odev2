// Interface
public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int id);
}

// Fake Product Service
public class FakeProductService : IProductService
{
    private List<Product> _products;

    public FakeProductService()
    {
        _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99m },
            new Product { Id = 2, Name = "Product 2", Price = 20.49m }
        };
    }

    // Diğer IProductService metotlarını da burada implemente edin.
}

// Startup.cs içerisinde
services.AddScoped<IProductService, FakeProductService>();
