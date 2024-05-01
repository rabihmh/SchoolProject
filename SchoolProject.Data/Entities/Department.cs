using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
            DepartmentSubjects = new HashSet<DepartmentSubject>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        
        [StringLength(200)]
        public string? DName { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        
    }
}
