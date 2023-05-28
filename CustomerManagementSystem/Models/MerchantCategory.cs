using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.Models
{
    public class MerchantCategory
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
