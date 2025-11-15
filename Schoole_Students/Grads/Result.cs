using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students
{
    public class Result
    {
      public  short Student_Id { set; get; }
       public string Name { set; get; }
        public string Class_Name { set; get; }
        public Dictionary<string, int> result = new Dictionary<string, int>();
        public float average;
        public int sum;
        /*
        string estimate = average switch
        {
            >= 90 => "ممتاز ",
            >= 80 => "جيد جدا  ",
            >= 70 => " جيد ",
            >= 60 => "مقبول ",
            >= 50 => "ضعيف ",
            _ => "ممتاز ",

        };
        */
       
       
       public string getEstimate(){
             switch(average){
                case float g when(g>= 90) :
                     return "ممتاز";
                    break;
                case float g when(g >= 80) :
                     return "جيد جدا ";
                    break;
                case float g when(g >= 70) :
                     return "جيد ";

                    break;
                case float g when(g >= 60) :
                     return "مقبول";
                    break;
                case float g when(g >= 60) :
                     return "ضعييف";
                    break;
                    default: 
                    return "راسب";
            }// التقدير
       
}



}
          
    }

