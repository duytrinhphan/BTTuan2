
namespace _5574_PhanVoDuyTrinh.Models
{
    public class MockProducRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public MockProducRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Vợt cầu lông Yonex Astrox 99", Price = 1000, Décription= "Độ cứng: Cứng."},
            };
        }
        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }
    }
}
