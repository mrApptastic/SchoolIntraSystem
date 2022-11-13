using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteinerAPI.Data 
{
    public class Pupil
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string Firstnames { get; set; } = "";
        public string Surname { get; set; } = "";
        public DateTime? DateOfBirth { get; set; }
    }
}