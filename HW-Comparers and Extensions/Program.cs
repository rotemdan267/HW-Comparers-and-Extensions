using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Comparers_and_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comparers-Question 1

            List<Student> students = new List<Student>(5);
            students.Add(new Student("moshe", "levi", 70));
            students.Add(new Student("yossi", "cohen", 80));
            students.Add(new Student("avi", "abrahami", 75));
            students.Add(new Student("ali", "alevi", 61));
            students.Add(new Student("baruch", "cohen", 78));
            students.Sort(new SortStudentByGrade());

            #endregion

            #region Comparers-Question 2

            List<Measurement> measurements = new List<Measurement>(5);
            measurements.Add(new Measurement("ggg", new DateTime(2000, 10, 20), 25.3f, 60));
            measurements.Add(new Measurement("eee", new DateTime(1998, 10, 20), 26.8f, 88));
            measurements.Add(new Measurement("eee", new DateTime(1998, 6, 20), 25.3f, 60));
            measurements.Add(new Measurement("aaa", new DateTime(1998, 6, 10), 22.7f, 70));
            measurements.Add(new Measurement("ccc", new DateTime(1999, 10, 20), 27.1f, 70));

            measurements.Sort(new SortMeasurementsD());

            #endregion



            #region Extensions-Q 1

            //string str = Console.ReadLine();
            //Console.WriteLine(str.ReverseCase());

            #endregion

            #region Extensions-Q 2

            //string str2 = Console.ReadLine();
            //Console.WriteLine(str2.ReverseCase());

            #endregion

            #region Extensions-Q 3

            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x.Print());

            #endregion

            #region Extensions-Q 4

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine(x.MultipleBy(y));

            #endregion

            #region Extensions-Q 5

            //object obj = null;
            //int x = 1;
            //Console.WriteLine(obj.IsNull());
            //Console.WriteLine(x.IsNull());

            #endregion

            #region Extensions-Q 6

            string id = Console.ReadLine();
            Console.WriteLine(id.IsValidIsraeliIdNumber());

            #endregion




            Console.ReadLine();
        }
    }
}
