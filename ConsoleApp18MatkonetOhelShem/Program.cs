namespace ConsoleApp18MatkonetOhelShem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] a =  {  1,5,5, 3,2 };
            Console.WriteLine(OleYored(a));
        }
        //question 1
        static bool OleYored(int[] arr)
        {
            int i;
            for (i = 0; i < arr.Length-1; i++)
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
    }
}