using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Education { get; set; }
        public string StudySubject { get; set; }
    }
}
