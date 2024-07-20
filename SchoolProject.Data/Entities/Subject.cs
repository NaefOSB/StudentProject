using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Entities
{
    public class Subject
    {
        public Subject()
        {
            Departments = new HashSet<DepartmentSubject>();
            Students = new HashSet<StudentSubject>();
        }

        #region Keys

        [Key] public int Id { get; set; }
        #endregion

        #region Scala Properties

        [StringLength(250)] public string Name { get; set; }
        public DateTime Period { get; set; }

        #endregion

        #region Navigation Properties

        public virtual ICollection<DepartmentSubject> Departments { get; set; }
        public virtual ICollection<StudentSubject> Students { get; set; }
        #endregion
    }
}
