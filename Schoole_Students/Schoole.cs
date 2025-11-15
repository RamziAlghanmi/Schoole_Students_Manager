using Schoole_Students.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students
{
    public class Schoole
    {
        IStudents ss= new StudentsManager();
       
        List<Student> students;
        public Schoole()
        {

            ss = new StudentsManager();
           
        }

        

    }

}
