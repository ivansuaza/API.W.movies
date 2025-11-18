using System.ComponentModel.DataAnnotations;

namespace API.W.movies.DATA.Models.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "el nombre de la categoria es obligatorio")]
        [MaxLength(100, ErrorMessage = "el nombre de la categoria no debe exceder los 100. caracteres")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
