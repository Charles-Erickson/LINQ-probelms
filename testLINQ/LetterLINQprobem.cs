using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testLINQ
{
    public class LetterLINQprobem
    {
       

        public static void Lettercount()
        {
        string testString = "hello";
        testString.Split();
            testString.Where(i => i.Count());
            var newTest = testString.Where(i => i.Count()) && testString.Select(i);
            newTest.OrderbyDescending();
        }

    }
}
