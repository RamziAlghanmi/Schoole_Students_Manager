using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students
{
    public interface IManager <T>
    {
        
        List<T> getAll();
       
    }
}
