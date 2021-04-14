using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class TeacherInfo
    {
        [Key]
        public int Id { get; set; }

        public string Education { get; set; }

        public string StudySubject { get; set; }
    }
}
