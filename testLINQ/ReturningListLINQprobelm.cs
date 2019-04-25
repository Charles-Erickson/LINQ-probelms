using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testLINQ
{
    public class ReturningListLINQprobelm
    {
        public static void MainList()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var queryList = names.Distinct();
                //.Where(i => i.Count() == 1)
                //.Select(i => i.Key);               
        }
    }
}
