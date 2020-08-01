using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength=10,ErrorMessage="10 ila 60 karakter arası girmelisiniz")]
        public string Name { get; set; }
        [Required(ErrorMessage="Fiyat Girmelisiniz")]
        [Range(1,10000)]//arası değer olabilir .. buralarda dataannations uyguluyoruz
        public double Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        [Required]
        public int? CategoryId { get; set; }
     
    }
}