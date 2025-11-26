using System.ComponentModel.DataAnnotations;

namespace API.W.movies.DATA.Models.Dtos
{
    public class CategoryCreateUpdateDto
    {
        [Required(ErrorMessage ="el nombre de la categoria es obligatorio")]
        [MaxLength(100, ErrorMessage ="el nombre de la categoria no debe exceder los 100. caracteres")]
        public string Name { get; set; }
    }
}
