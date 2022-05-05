using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsList
{
    public class ListExercise
    {
        public static List<int> Solution()
        {
            List<int> list = new List<int>();
            for (int i = 100; i <= 170; i+=2)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                Console.Write(item+" ");
            }

            return list;
        }
    }
}
