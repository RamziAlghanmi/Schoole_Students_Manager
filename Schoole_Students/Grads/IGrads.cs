using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students.Grads
{
    public interface IGrads
    {
        void addGrads(Grad su);
        void updateGrads(Grad su);
        List<Grad> getAllGrads();
        Result createResult(int student_id);


    }
}
