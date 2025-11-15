using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.Grads
{

    public class GradsManager : IGrads
    {
       
        public List<Grad> getAllGrads()
        {
            List<Grad> grads = new List<Grad>();
            using(var g_grads = new SchooleDBContext())
            {
                var grs = g_grads.GRADS.ToList();
                foreach(var gr in grs)
                {
                    grads.Add(new Grad(gr.STUDENT_ID, gr.SUBJECT_ID, gr.VALUE));
                }
            }
            return grads;
        }

       public void addGrads(Grad su)
        {
            using (var g_grads = new SchooleDBContext())
            {
              g_grads.GRADS.Add(new GRADS { STUDENT_ID = su.Student_Id,
                  SUBJECT_ID = su.Subject_Id,VALUE = su.grade});
                g_grads.SaveChanges();
            }
        }

        public void updateGrads(Grad su)
        {
            using (var g_grads = new SchooleDBContext())
            {
             var gr=g_grads.GRADS.Find(su.Student_Id, su.Subject_Id);
                gr.VALUE = su.grade; 
                g_grads.SaveChanges();
            }
        }

        public Result createResult(int student_id)
        {
            Result result = new Result();

            return result;
        }
    }
}
