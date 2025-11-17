using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.Subjects
{
    public interface ISubjects
    {
        void addSubject(Subject su);
        int getNewId();
        BindingList<Subject> getAllSubjects();
        void updateSubject(Subject su);
        void deleteSubject(short id);
        bool found(BindingList<Subject> list, short id);
        int search(BindingList<Subject> list, short id);
    }
}
