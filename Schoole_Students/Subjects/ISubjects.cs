using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.Subjects
{
    public interface ISubjects
    {
        void addSubject(Subject su);
        //List<Subject> getAllSubjects();
        void updateSubject(Subject su);
        void deleteSubject(short id);
        bool found(List<Subject> list, short id);
    }
}
