using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.Grads
{
    public class Grad
    {
        public int Student_Id { set; get; }
        public int Subject_Id { set; get; }
        public int grade { set; get; }
        public Grad(int student_Id, int subject_Id, int grade=0)
        {
            this.Student_Id = student_Id;
            this.Subject_Id = subject_Id;
            this.grade = grade;
        }
    }
}
