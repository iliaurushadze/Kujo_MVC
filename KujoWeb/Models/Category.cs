using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KujoWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 200, ErrorMessage ="Display Order Must Be between 1 And 100 Only!!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
