using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolIntraAPI.Data 
{
    public class UserRole
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string RoleName { get; set; } = "";

    }
}