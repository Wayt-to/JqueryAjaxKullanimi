using System.ComponentModel.DataAnnotations;

namespace JqueryAjaxKullanimi.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ürün adı boş bırakılamaz")]
        [StringLength(maximumLength: 120, ErrorMessage = "Error Message")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}