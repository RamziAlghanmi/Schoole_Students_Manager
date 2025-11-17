using Schoole_Students.Grads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoole_Students.Grads;
using System.ComponentModel;

namespace Schoole_Students.Students
{
    public interface IStudents
    {
        void addStudent(Student st);
        int getNewId();
        BindingList<Student> getAllStudents();
        void updateStudent(Student st);
        void deleteStudent(int id);
        BindingList<Grad> getGrads(BindingList<Grad> all_grads, int student_id);
        bool found(BindingList<Student> list, int id);
        int search(BindingList<Student> list, int id);
    }
}
