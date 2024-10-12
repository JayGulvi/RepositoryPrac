using System.ComponentModel.DataAnnotations;

namespace RepoPatternPrac.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter Product Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter Country")]
        public string PManuFacCountry { get; set; }


        [Required(ErrorMessage ="Enter Price")]
        public int Price  { get; set; }
    }
}
