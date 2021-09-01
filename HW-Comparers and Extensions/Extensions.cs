using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Comparers_and_Extensions
{
    static class Extensions
    {
        #region Extensions-Q 1

        public static bool HasLowerChars(this string str)
        {
            foreach (char item in str)
            {
                if (item >= 'a' && item <= 'z')
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Extensions-Q 2

        public static string ReverseCase(this string str)
        {
            string newStr = "";
            foreach (char item in str)
            {
                if (item >= 'a' && item <= 'z')
                {
                    newStr += item.ToString().ToUpper();
                }
                else if (item >= 'A' && item <= 'Z')
                {
                    newStr += item.ToString().ToLower();
                }
                else newStr += item;
            }
            return newStr;
        }

        #endregion

        #region Extensions-Q 3

        public static string Print(this int x)
        {
            string str = "";
            int units, tens;
            if (x > 100)
            {
                str = "Ad Kan!";
            }
            else
            {
                if (x == 100)
                {
                    str = "One Hunderd";
                }
                else
                {
                    tens = x / 10;
                    units = x % 10;
                    switch (tens)
                    {
                        case 9:
                            str += "Ninety " + Units(units, tens);
                            break;

                        case 8:
                            str += "Eighty " + Units(units, tens);
                            break;

                        case 7:
                            str += "Seventy " + Units(units, tens);
                            break;

                        case 6:
                            str += "Sixty " + Units(units, tens);
                            break;

                        case 5:
                            str += "Fifty " + Units(units, tens);
                            break;

                        case 4:
                            str += "Forty " + Units(units, tens);
                            break;

                        case 3:
                            str += "Thirty " + Units(units, tens);
                            break;

                        case 2:
                            str += "Twenty " + Units(units, tens);
                            break;

                        case 1:
                            str += Units(units, tens) + "teen";
                            if (units == 1)
                            {
                                str = "Eleven";
                            }
                            if (units == 2)
                            {
                                str = "Twelve";
                            }
                            break;

                        case 0:
                            str += Units(units, tens);
                            break;
                    }
                }
            }
            return str;
        }
        private static string Units(int units, int tens)
        {
            string str = "";
            switch (units)
            {
                case 9:
                    str = "Nine";
                    break;

                case 8:
                    str = "Eight";
                    break;

                case 7:
                    str = "Seven";
                    break;

                case 6:
                    str = "Six";
                    break;

                case 5:
                    str = "Five";
                    if (tens == 1)
                    {
                        str = "Fif";
                    }
                    break;

                case 4:
                    str = "Four";
                    break;

                case 3:
                    str = "Three ";
                    if (tens == 1)
                    {
                        str = "Thir";
                    }
                    break;

                case 2:
                    str = "Two ";
                    break;

                case 1:
                    str = "One";
                    break;

                case 0:
                    if (tens == 0)
                    {
                        str = "Zero";
                    }
                    break;
            }
            return str;
        }

        #endregion

        #region Extensions-Q 4

        public static int MultipleBy(this int x, int y)
        {
            return x * y;
        }

        #endregion

        #region Extensions-Q 5

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        #endregion

        #region Extensions-Q 6

        public static bool IsValidIsraeliIdNumber(this string ID)
        {
            int id;
            if (!int.TryParse(ID, out id))
            {
                return false;
            }
            else if (id <= 99999999 || id >= 1000000000)  // בדיקה שהמספר אכן בעל 9 ספרות
            {
                return false;
            }
            else
            {
                int[] idDigits = new int[9];
                for (int i = 0; i < idDigits.Length; i++)
                {
                    idDigits[i] = id % 10;
                    id /= 10;
                }
                for (int i = 1; i < idDigits.Length; i++)
                {
                    idDigits[i] *= ((i % 2) + 1);
                    if (idDigits[i] >= 10)
                    {
                        int units = idDigits[i] % 10;
                        idDigits[i] = units + 1; // ספרת העשרות לא יכולה להיות יותר מ-1, המקרה הכי קיצוני הוא שהספרה הייתה 9 ואז לאחר הכפלה ב-2 היא 18
                    }
                }
                int sum = 0;
                for (int i = 1; i < idDigits.Length; i++)
                {
                    sum += idDigits[i];
                }
                int count = 0;
                while (sum % 10 != 0)
                {
                    sum++;
                    count++;
                }
                if (count == idDigits[0])
                {
                    return true;
                }
                else return false;
            }
        }

        #endregion
    }
}
