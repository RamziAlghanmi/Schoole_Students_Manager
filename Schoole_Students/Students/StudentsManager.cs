using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoole_Students.Grads;

namespace Schoole_Students.Students
{
    public class StudentsManager :IStudents
    {
       
        public List <Student> getAllStudents()
        {           
            List<Student> students = new List<Student>();
            using(var g_students   = new SchooleDBContext())
            {
                var sts = g_students.STUDENTS.ToList();
                foreach (var st in sts)
                {                        
                    students.Add(new Student(st.Id, st.NAME, st.ADDRESS, st.BIRTH,
                     st.CLASS_ID, st.PHOTO, st.GENDER, st.PHONE,  st.EMAILE));
                }
            }
            return students;

        }

        public void addStudent(Student st)
        {
           using(var g_students = new SchooleDBContext())
            {
                g_students.STUDENTS.Add(new STUDENTS
                {
                    NAME = st.Student_Name,
                    ADDRESS = st.Student_Address,
                    BIRTH =st.Student_Date,PHOTO= st.Student_Photo,
                    CLASS_ID=st.Class_Id, GENDER=st.Student_Gender,
                    PHONE= st.Student_Phone, EMAILE=st.Student_Emaile});
                g_students.SaveChanges();
            }
            
        }

        public void updateStudent(Student st)
        {
            using (var g_students = new SchooleDBContext())
            {
                var nst = g_students.STUDENTS.Find(st.Student_Id);


                nst.NAME = st.Student_Name;
                nst.ADDRESS = st.Student_Address;
                nst.BIRTH = st.Student_Date;
                nst.PHOTO = st.Student_Photo;
                nst.CLASS_ID = st.Class_Id;
                nst.GENDER = st.Student_Gender;
                nst.PHONE = st.Student_Phone;
                nst.EMAILE = st.Student_Emaile;
               g_students.SaveChanges();
            }
        }

        public void deleteStudent(int id)
        {
            using (var g_students = new SchooleDBContext())
            {
                var nst = g_students.STUDENTS.Find(id);
                g_students.STUDENTS.Remove(nst);
                g_students.SaveChanges();
            }
            }
         public List<Grad> getGrads(List<Grad> all_grads, int student_id)
        {
            List<Grad> custom_grads = new List<Grad>();
            foreach (Grad gr in all_grads) {
                if (gr.Student_Id == student_id)
                {
                    custom_grads.Add(gr);
                }
            }
            return custom_grads;
        }
        public bool found(List<Student> list, int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Student_Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public int search(List<Student> list, int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Student_Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
