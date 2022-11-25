using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolIntraAPI.Data 
{
    public class SchoolClass
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public ICollection<Pupil> Pupils { get; set; } = new List<Pupil>();
    }
}