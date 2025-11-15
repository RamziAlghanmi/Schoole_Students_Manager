using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.ClassRooms
{
    public interface IClassRooms 
    {
        void addClassRoom(ClassRoom cr);
        List<ClassRoom> getAllClassRooms(List<Student> all_students);
        void updateClassRoom(ClassRoom cr);
        void deleteClassRoom(int id);
        bool found(List<ClassRoom> list, int id);
        int search(List<ClassRoom> list, int id);
    }
}
