using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        #region Keys

        public Student()
        {
            Subjects = new HashSet<StudentSubject>();
        }

        [Key] public int Id { get; set; }
        [ForeignKey("Department")] public int DepartmentId { get; set; }
        #endregion

        #region Scala Properties

        [StringLength(250)] public string Name { get; set; }
        [StringLength(250)] public string Address { get; set; }
        [StringLength(15)] public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        #endregion

        #region Navigation Properties

        public virtual Department Department { get; set; }
        public virtual ICollection<StudentSubject> Subjects { get; set; }
        #endregion
    }
}
