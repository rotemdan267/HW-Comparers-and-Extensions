using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Comparers_and_Extensions
{
    class SortMeasurementsA : IComparer<Measurement>
    { // לפי עיר
        public int Compare(Measurement x, Measurement y)
        {
            return x.City.CompareTo(y.City);
        }
    }
    class SortMeasurementsB : IComparer<Measurement>
    { // לפי עיר, תאריך
        public int Compare(Measurement x, Measurement y)
        {
            if (x.City.CompareTo(y.City) == 0)
            {
                return x.Date.CompareTo(y.Date);
            }
            else return x.City.CompareTo(y.City);
        }
    }
    class SortMeasurementsC : IComparer<Measurement>
    { // לפי טמפרטורות בסדר יורד, עיר בסדר עולה
        public int Compare(Measurement x, Measurement y)
        {
            if (x.Temp.CompareTo(y.Temp) == 0)
            {
                return x.City.CompareTo(y.City);
            }
            else return x.Temp.CompareTo(y.Temp) * -1;
        }
    }
    class SortMeasurementsD : IComparer<Measurement>
    { // לפי לחות בסדר יורד, טמפ' יורד, עיר עולה
        public int Compare(Measurement x, Measurement y)
        {
            SortMeasurementsC sort = new SortMeasurementsC();

            if (x.Moisture.CompareTo(y.Moisture) == 0)
            {
                return sort.Compare(x, y);
            }
            else return x.Moisture.CompareTo(y.Moisture) * -1;
        }
    }

    class Measurement
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public float Temp { get; set; }
        public int Moisture { get; set; }

        public Measurement(string city, DateTime date, float temp, int moisture)
        {
            City = city;
            Date = date;
            Temp = temp;
            Moisture = moisture;
        }
        public override string ToString()
        {
            return this.City + " " + this.Date + " " + this.Temp + " " + this.Moisture;
        }
    }
}
