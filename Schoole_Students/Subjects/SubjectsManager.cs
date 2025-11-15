using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Schoole_Students.Subjects
{
    public class SubjectsManager : ISubjects
    {

        public List<Subject> getAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            using (var g_subjects = new SchooleDBContext())
            {
                var sus = g_subjects.SUBJECTS.ToList();
                foreach (var s in sus)
                {
                    subjects.Add(new Subject(s.ID,s.NAME,s.CLASS_ID,"Not Found", s.AUTHER));
                }
            }
            return subjects;
        }

        public void addSubject(Subject su)
        {
            using(var g_subjects = new SchooleDBContext())
            {
                g_subjects.SUBJECTS.Add(new SUBJECTS
                {
                    NAME = su.Subject_Name,
                    CLASS_ID = su.Class_Id,
                    AUTHER = su.Subject_Auther
                });
               
            }
        }

        public void updateSubject(Subject su)
        {
            using (var g_subjects = new SchooleDBContext())
            {
                var s = g_subjects.SUBJECTS.Find(su.Subject_Id);
                s.NAME = su.Subject_Name;
                s.CLASS_ID = su.Class_Id;
                s.AUTHER = su.Subject_Auther;
            }
        }

        public void deleteSubject(short id)
        {
            using (var g_subjects = new SchooleDBContext())
            {
                var s = g_subjects.SUBJECTS.Find(id);
                g_subjects.SUBJECTS.Remove(s);
            }
        }
        public bool found(List<Subject> list, short id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Subject_Id == id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
