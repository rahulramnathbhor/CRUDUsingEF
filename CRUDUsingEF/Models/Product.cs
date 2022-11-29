using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDUsingEF.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]

        public int Id { get; set; }
        [Required(ErrorMessage = "name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "company name is Required")]
        [Display(Name = "company name")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "price  is Required")]
        public decimal Price { get; set; }
    }
}