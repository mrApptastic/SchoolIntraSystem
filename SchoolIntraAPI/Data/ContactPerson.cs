using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolIntraAPI.Data 
{
    public class ContactPerson
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string Firstnames { get; set; } = "";
        public string Surname { get; set; } = "";
        public virtual ICollection<Pupil> Pupils { get; set; } = new List<Pupil>();
    }
}