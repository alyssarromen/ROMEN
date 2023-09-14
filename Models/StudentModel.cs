namespace RomenITELEC1C.Models
{
    public enum Course
    {
        BSCS, BSIT,BSIS
    }
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateEnrolled { get; set; }
        public Course StudentCourse { get; set; }
        public string Email { get; set; }

    }
}
