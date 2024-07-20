using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities
{
    public class DepartmentSubject
    {
        #region Keys

        [Key] public int Id { get; set; }
        [ForeignKey("Department")] public int DepartmentId { get; set; }
        [ForeignKey("Subject")] public int SubjectId { get; set; }
        #endregion

        #region Scala Properties

        #endregion

        #region Navigation Properties

        public virtual Department Department { get; set; }
        public virtual Subject Subject { get; set; }
        #endregion
    }
}
