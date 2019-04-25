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
            List<double> Averages = new List<double>();
            for (int i = 0; i < classGrades.Count; i++)
            {
                classGrades[i].Split(",");
                classGrades[i].OrderByDescending(u => u);
                classGrades[i].Reverse().Skip(1).Reverse();
                var arrray = classGrades[i];
                Average[i] = arrray.Average();
               
            }
            Averages.Average();
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

