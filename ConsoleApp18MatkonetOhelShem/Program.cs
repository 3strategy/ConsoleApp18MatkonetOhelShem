﻿using System.ComponentModel.DataAnnotations;

namespace ConsoleApp18MatkonetOhelShem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree(2, "TLV");
            Tree t2 = new Tree(1, "Kfr-S");
            Console.WriteLine(t1.SameLocation(t2));
            ///Console.WriteLine("Hello, World!");
            int[] a = { 1, 5, 5, -1,9,9,9,8,-1,8,3, 2 };
            Console.WriteLine(BiggestNumber(a));
            char[] cc = {'g', 'a', 'g', 'c', 'b' ,'h'};
            Switch(cc);
        }
        //question 1
        public static bool OleYored(int[] arr)
        {
            int i;
            for (i = 0; i < arr.Length - 1; i++)
                if (arr[i + 1] <= arr[i]) // top is marked by !>
                                          // (i.e. <= and not by <
                    break;

            if (i == 0 || arr[i + 1] == arr[i])
                return false;

            for (; i < arr.Length - 1; i++) // continue from where we stopped
                if (arr[i + 1] >= arr[i])
                    return false;

            return true;
        }

        // לקבל מערך שלמים ולראות אם הוא עולה ממש ואחר כך יורד ממש
        // 5 8 9 7 3=ok    1 3 3 1 not ok.     not ok 1 5,5 7 8 7 7 5 2 
        // 1 2 2 3 1 =not ok.     5 3 1 not ok
        // וידוע שיש לפחות 3 איברים
        public static bool OleYored2(int[] arr)
        {
            int prevNum = arr[0];
            int ind = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                ind = i;
                if (prevNum >= arr[i])
                {
                    break;
                }
                prevNum = arr[i];
            }
            for (int i = ind; i < arr.Length; i++)
            {
                if (prevNum <= arr[i])
                {
                    return false;
                }
                prevNum = arr[i];
            }

            return true;
        }


        //לקוח פרימיום premium – מקבל התראה רק על עסקאות אשר עולות על 30,000 שקלים חדשים.
        //לקוח רגיל standard – מקבל התראה על עסקאות אשר עולות על 2500 שקלים חדשים.
        //לקוח מוגבל limited – מקבל התראה על עסקאות אשר עולות על 100 שקלים חדשים.
        //א.כתבו פעולה Alert המקבלת את סוג הלקוח כמחרוזת ואת סכום העסקה כמספר ממשי ומחזירה אמת במידה ויש להוציא
        //התראה ללקוח ושקר אחרת.
        //question 2
        public static bool Alert(string cType, double amount)
        {
            return amount >= 30000 && cType == "premium" ||
                amount >= 2500 && cType == "standard" ||
                amount >= 100 && cType == "limited";
        }

        //question 2b
        //כתבו פעולה MonthlyCheck אשר מקבלת את סוג הלקוח, הפעולה עוברת על חשבון העסקאות של הלקוח. עבור כל עסקה
        //יש לקלוט את סכומה מטיפוס מספר ממשי.עסקאות יקלטו עד אשר תקלט עסקה שערכה הוא )-1(.
//a.הפעולה תציג כמה התראות יקבל הלקוח באותו פרק הזמן.חובה להשתמש בפעולה מסעיף א.
//b.בנוסף, יש להציג את סכום ההתראה הממוצע באותו החודש.

        public static void MonthlyCheck (string cType)
        {
            double sum = 0;
            int count = 0;
            while (true)
            {
                Console.WriteLine("enter ammount, -1 to stop");

                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                    break;
                if(Alert(cType,n))
                {
                    sum += n;
                    count++;
                }
            }
            Console.WriteLine("# of alerts : " + count);
            Console.WriteLine(" Average = " + sum/count);
        }

        //question 3
        public static void Switch(char[] arr)
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] + 1 == arr[^(i+1)])
                {
                    char tmp = arr[i];
                    arr[i] = arr[^(i + 1)];
                    arr[^(i + 1)] = tmp;
                }    
            }
        }

        //question 4
        public static int BiggestNumber(int[] arr)
        {
            // -1 signifies a new number is coming
            int n = 0, max = int.MinValue;
            foreach (var dig in arr)
            {
                if (dig > -1)
                    n = n * 10 + dig;
                else // new number starts now
                {
                    if (n > max)
                        max = n;
                    n = 0;
                }
            }
            if (n > max) 
                return n;
            return max;
        }


    }
}