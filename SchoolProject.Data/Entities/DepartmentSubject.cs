using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int DID { get; set; }
        public int SubID { get; set; }

        [ForeignKey("DID")]
        [InverseProperty("DepartmentSubjects")]
        public virtual Department? Department { get; set; }

        [ForeignKey("SubID")]
        [InverseProperty("DepartmetsSubjects")]
        public virtual Subject? Subject { get; set; }
    }
}
