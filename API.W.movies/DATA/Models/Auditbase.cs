using System.ComponentModel.DataAnnotations;

namespace API.W.movies.DATA.Models
{
    public class Auditbase
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
