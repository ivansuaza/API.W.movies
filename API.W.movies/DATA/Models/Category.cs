using System.ComponentModel.DataAnnotations;

namespace API.W.movies.DATA.Models
{
    public class Category : Auditbase
    {
        [Required]
        [Display(Name = "Category Name")]
        public String Name { get; set; }
    }
}
