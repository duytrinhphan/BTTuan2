using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _5574_PhanVoDuyTrinh.Models
{
    public class Product
    {
        [DisplayName ("Mã SP")]
        public int Id { get; set; }
        [Required, StringLength(100)]
        [DisplayName ("Tên SP")]
        public string Name { get; set; }
        [Required, Range(0.001,10000.00)]
        [DisplayName ("Giá Tiền")]
        public decimal Price { get; set; }
        [DisplayName ("Mô Tả")]
        public string Décription { get; set; }
        [DisplayName ("Loại SP")]
        public int CategoryID {  get; set; }
        public string? ImageUrl { get; set; } 
        public List<string>? ImageUrls { get; set; }
    }
}
