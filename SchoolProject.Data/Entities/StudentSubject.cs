using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities
{
    public class StudentSubject
    {
        #region Keys

        [Key] public int Id { get; set; }
        [ForeignKey("Student")] public int StudentId { get; set; }
        [ForeignKey("Subject")] public int SubjectId { get; set; }
        #endregion

        #region Scala Properties

        #endregion

        #region Navigation Properties

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        #endregion
    }
}
