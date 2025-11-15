using Schoole_Students.Grads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoole_Students.Students;

namespace Schoole_Students.ClassRooms
{
    public class ClassRoomsManager : IClassRooms
    {
        IStudents student_manager = new StudentsManager();
        public List<ClassRoom> getAllClassRooms(List<Student> all_students)
        {
            List<ClassRoom> rooms = new List<ClassRoom>();
            List<Student> custom_students = new List<Student>();
            using (var class_rooms = new SchooleDBContext())
            {
               
                var room = class_rooms.CLASSROOMS.ToList();
                foreach(var cr in room) {
                    custom_students = getCustomStudents(all_students,cr.ID);
                    
                    rooms.Add(new ClassRoom(cr.ID, cr.NAME, cr.MAXCAPACITY, custom_students));
                }
            }
                return rooms;
        }

        public void addClassRoom(ClassRoom cr)
        {
           using (var class_rooms = new SchooleDBContext())
            {
                class_rooms.CLASSROOMS.Add(new CLASSROOMS {NAME = cr.Class_Room_Name, MAXCAPACITY = cr.Max_Capacity });
                class_rooms.SaveChanges();
            }
        }

        public void updateClassRoom(ClassRoom cr)
        {
            using (var class_rooms = new SchooleDBContext())
            {
               var clr= class_rooms.CLASSROOMS.Find(cr.Class_Room_Id);
                clr.NAME = cr.Class_Room_Name;
                clr.MAXCAPACITY = cr.Max_Capacity;
                class_rooms.SaveChanges();
            }
        }

        public void deleteClassRoom(int id)
        {
            using (var class_rooms = new SchooleDBContext())
            {
                var clr = class_rooms.CLASSROOMS.Find(id);
                class_rooms.CLASSROOMS.Remove(clr);
                class_rooms.SaveChanges();
            }
        }

        public List<Student> getCustomStudents(List<Student> all_students, int class_id)
        {
            List<Student> students = new List<Student>();
            foreach (Student st in all_students)
            {
                if (st.Class_Id == class_id)
                {
                    students.Add(st);
                }
            }
            return students;
        }
        public bool found(List<ClassRoom> list, int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Class_Room_Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public int search(List<ClassRoom> list, int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Class_Room_Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
