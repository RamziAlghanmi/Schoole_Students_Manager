using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoole_Students.Grads;

namespace Schoole_Students
{
    public  class Student
    {
        public int Student_Id { get; set; } 
        public string Student_Name { get; set; }
        public string Student_Emaile { get; set; }
        public string Student_Address { get; set; }
        public string Student_Phone { get; set; }
        public byte[] Student_Photo { get; set; }
        public string Student_Gender { get; set; }
        public DateTime? Student_Date { get; set; }
        public int Class_Id { get; set; }
        public BindingList<Grad> grads { get; set; }

        public Student(string student_Name,
            string student_Address, DateTime? student_Date,
            int class_id, byte[] student_Photo,
            string student_Phone,
            string Student_Gender = "Man",
            string student_Emaile = "aaaa@gmail.com"
            
           )

        {
            
            this.Student_Name = student_Name;
            this.Student_Emaile = student_Emaile;
            this.Student_Address = student_Address;
            this.Student_Phone = student_Phone;
            this.Student_Gender = Student_Gender;
            this.Student_Photo = student_Photo;
            this.Student_Date = student_Date;
            this.Class_Id = class_id;
           
        }
    
    public Student(int id, string student_Name,
            string student_Address, DateTime? student_Date,        
            int class_id,
            byte[] student_Photo,
            string student_Phone,
            string Student_Gender ,
            string student_Emaile 
            
           )
        :this(student_Name, student_Address, student_Date, class_id, student_Photo, 
             student_Phone, Student_Gender, student_Emaile)
        {
            this.Student_Id = id;   
           
        }
        public Student(int id, string student_Name,
           string student_Address, DateTime? student_Date,
           byte[] student_Photo,
           int class_id,
           string student_Phone,
           string Student_Gender,
           string student_Emaile,
           BindingList<Grad> grads
          )
       : this(id,student_Name, student_Address, student_Date, class_id, student_Photo,
            student_Phone, Student_Gender, student_Emaile)
        {
            this.grads = grads;  

        }

    }
}
