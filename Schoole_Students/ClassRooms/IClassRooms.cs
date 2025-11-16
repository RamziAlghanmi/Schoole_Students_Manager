using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.ClassRooms
{
    public interface IClassRooms 
    {
        
        void addClassRoom(ClassRoom cr);
        BindingList<ClassRoom> getAllClassRooms();
        Dictionary<int, string> getRoomDictionary(BindingList<ClassRoom> roomList);
        BindingList<Student> getCustomStudents(BindingList<Student> all_students, int class_id);
        void updateClassRoom(ClassRoom cr);
        void deleteClassRoom(int id);
        bool found(BindingList<ClassRoom> list, int id);
        int search(BindingList<ClassRoom> list, int id);
    }
}
