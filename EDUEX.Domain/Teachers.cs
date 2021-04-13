using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Teachers
    {
        [Key]
        public int Id { get; set; }
        public string Education { get; set; }
        public string StudySubject { get; set; }
        public User User {get;set;}
        public int UserId { get; set; }
    }
}
