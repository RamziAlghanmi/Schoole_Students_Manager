using Schoole_Students.Grads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoole_Students.Grads;

namespace Schoole_Students.Students
{
    public interface IStudents
    {
        void addStudent(Student st);
        List<Student> getAllStudents();
        void updateStudent(Student st);
        void deleteStudent(int id);
        List<Grad> getGrads(List<Grad> all_grads, int student_id);
        bool found(List<Student> list, int id);
        int search(List<Student> list, int id);
    }
}
