using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class StudentSubject
    {
        [Key]
        public int StudID { get; set; }
        public int SubID { get; set; }
        public decimal? grade { get; set; }

        [ForeignKey("StudID")]
        public virtual Student? Student { get; set; }

        [ForeignKey("SubID")]
        [InverseProperty("StudentsSubjects")]
        public virtual Subject? Subject { get; set; }

    }
}
