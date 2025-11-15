using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.Subjects
{
    public class Subject
    {
        public  int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public string Subject_Link { get; set; }
        public  string Subject_Auther { get; set; }
        public int? Class_Id { get; set; }

        public Subject(int subject_Id, string subject_Name, int? class_id)
        {
            this.Subject_Id = subject_Id;
            this.Subject_Name = subject_Name;
            this.Class_Id = class_id;   
            
        }
        public Subject(int subject_Id, string subject_Name, int? class_id, 
                       string subject_Link, string subject_Auther)
          // invoke the constractor
            :this(subject_Id, subject_Name, class_id)
        {
           
            this.Subject_Link = subject_Link;
            this.Subject_Auther = subject_Auther;
        }

        }
}
