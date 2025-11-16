using Schoole_Students.Grads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoole_Students.Students;
using System.ComponentModel;

namespace Schoole_Students.ClassRooms
{
    public class ClassRoomsManager : IClassRooms
    {
        
        public BindingList<ClassRoom> getAllClassRooms()
        {
            BindingList<ClassRoom> rooms = new BindingList<ClassRoom>();
            
            using (var class_rooms = new SchooleDBContext())
            {
               
                var room = class_rooms.CLASSROOMS.ToList();
                foreach(var cr in room) {                   
                    rooms.Add(new ClassRoom(cr.ID, cr.NAME, cr.MAXCAPACITY));
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

        public BindingList<Student> getCustomStudents(BindingList<Student> all_students, int class_id)
        {
            BindingList<Student> students = new BindingList<Student>();
            foreach (Student st in all_students)
            {
                if (st.Class_Id == class_id)
                {
                    students.Add(st);
                }
            }
            return students;
        }

        public Dictionary<int, string> getRoomDictionary(BindingList<ClassRoom> roomList)
        {
            Dictionary<int , string > roomDictionary = new Dictionary<int, string>();
            foreach(ClassRoom room in roomList)
            {
                roomDictionary.Add(room.Class_Room_Id, room.Class_Room_Name);
            }
            return roomDictionary;

        }
        public bool found(BindingList<ClassRoom> list, int id)
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

        public int search(BindingList<ClassRoom> list, int id)
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
