using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testLINQ
{
    public class AvaerageLINQprobelm
    {
        public static void Average()
        {
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            var classAverage = classGrades.Select(g => (Array.ConvertAll(g.Split(','), int.Parse)));
            var gpa=classAverage.Select(g => g.Where(a => g.Min() != a).Average()).Average();
            Console.WriteLine(gpa);
            Console.ReadKey();
        }
            


    }
        //static void MainAverage()
        //{
//            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
//            for (int i = 0; i < classGrades.Count; i++)
//            {
//                .Split()
//                //classGrades[i].Split(",");
//                //for (int c = 0; c < classGrades[i].Length; c++)
//                //{
//                //    double.Parse(classGrades[i]);
//                //    Array[] array = classGrades[i];
//                //}

//            } 
//        .Select(a => new { Lat = double.Parse), Long = double.Parse(a) });
//        }
//    }
}

