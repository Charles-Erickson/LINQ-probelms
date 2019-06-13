using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testLINQ
{
    public class th_probelm
    {
        public static void Namesearch()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathmatics" };
            var queryList = words.Where(m => m.Contains("%th%"));
            Console.WriteLine(queryList);
            Console.ReadKey();
       


            //var queryList = words.Contains("%th%").ToList();

            //where(w =>
        }
    }
}

