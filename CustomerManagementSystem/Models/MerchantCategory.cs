using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.Models
{
    public class MerchantCategory
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Display order must be btween 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
