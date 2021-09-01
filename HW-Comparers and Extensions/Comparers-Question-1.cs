using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Comparers_and_Extensions
{

    class SortStudentByGrade : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Grade.CompareTo(y.Grade) * -1;
        }
    }

    class Student : IComparable<Student>
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Grade { get; set; }

        public Student(string fName, string lName, int grade)
        {
            FName = fName;
            LName = lName;
            Grade = grade;
        }

        public int CompareTo(Student other)
        {
            // return this.LName.CompareTo(other.LName);  מיון לפי שם משפחה

            // return this.Grade.CompareTo(other.Grade) * -1; מיון לפי ציון בסדר יורד

            if (this.LName.CompareTo(other.LName) == 0)
            {
                return this.FName.CompareTo(other.FName);
            }
            else return this.LName.CompareTo(other.LName);
        }
        public override string ToString()
        {
            return this.FName + " " + this.LName + " " + this.Grade;
        }
    }
}
