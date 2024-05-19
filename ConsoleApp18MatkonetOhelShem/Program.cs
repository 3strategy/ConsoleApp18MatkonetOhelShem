using System.ComponentModel.DataAnnotations;

namespace ConsoleApp18MatkonetOhelShem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree[] tresssss = new Tree[100];

            StatusReport SR = new StatusReport(3, tresssss);
            Tree t = SR.GetTree(3);
            ///Console.WriteLine("Hello, World!");
            int[] a = { 1, 5, 5, -1,9,9,9,8,-1,8,3, 2 };
            Console.WriteLine(BiggestNumber(a));
            char[] cc = {'g', 'a', 'g', 'c', 'b' ,'h'};
            Switch(cc);
        }
        //question 1
        static bool OleYored(int[] arr)
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