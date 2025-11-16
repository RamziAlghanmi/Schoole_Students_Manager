using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students
{
    public class ClassRoom
    {
        public int Class_Room_Id { get; set; }
        public string Class_Room_Name { get; set; }
        public int? Max_Capacity { get; set; }
        public BindingList<Student> Students { get; set; }
        public ClassRoom( string class_Room_Name, int? capacity = 50)
        {
           
            this.Class_Room_Name = class_Room_Name;
            this.Max_Capacity = capacity;
            

        }
        public ClassRoom(int id, string class_Room_Name,  int? capacity)
          :this( class_Room_Name,capacity)
        {   
            this.Class_Room_Id= id;
         
          
        }
    }
}
