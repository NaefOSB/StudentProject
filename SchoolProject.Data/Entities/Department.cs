using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Entities
{
    public class Department
    {

        public Department()
        {
            Students = new HashSet<Student>();
            Subjects = new HashSet<DepartmentSubject>();
        }

        #region Keys

        [Key] public int Id { get; set; }

        #endregion

        #region Scala Properties

        [StringLength(250)] public string Name { get; set; }
        #endregion

        #region Navigation Properties

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmentSubject> Subjects { get; set; }
        #endregion
    }
}
