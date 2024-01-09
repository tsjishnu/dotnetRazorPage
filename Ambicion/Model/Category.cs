using System.ComponentModel.DataAnnotations;

namespace Ambicion.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Dispaly Order")]
        [Range(0,10,ErrorMessage = "Display Order Should be between 0 & 100")]
        public int DisplayOrder {  get; set; }

    }
}
