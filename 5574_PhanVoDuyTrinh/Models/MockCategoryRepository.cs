
namespace _5574_PhanVoDuyTrinh.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
        {
        new Category { Id = 1, Name = "Vợt Thiên Công" },
        new Category { Id = 2, Name = "Vợt Thiên Thủ" },
        };
    }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
