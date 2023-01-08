using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolIntraAPI.Data 
{
    public class User
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string UserName { get; set; } = "";
        public string PassWord { get; set; } = "";
        public UserType Type { get; set; } = UserType.Employee;
        public Guid? RelationId { get; set; } = null;
        public ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
    }

    public enum UserType {
        ContactPerson,        
        Pupil,
        Employee
    }
}