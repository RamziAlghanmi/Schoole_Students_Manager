using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoole_Students 
{
    public class Manager <T> : IManager<T>
    {
        public List<T> getAll()
        {
            List<T> list = new List<T>();
            return list;
        }

       
        /*
      public  bool found(List<T> list, short id)
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
        */
    }
}
