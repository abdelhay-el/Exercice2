namespace Exercice2
{
    class Program
    {

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("[" + a[i] + "] ");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int[] a = { 10, 20, 30, 40, 50 };
            Print(a);
            Array.Resize(ref a, a.Length + 1);
            int size = a.Length;
            a[size - 1] = n;
            Console.WriteLine("\n");
            for (int i = size - 1; i > 0; i--)
            {
                int tmp;
                if (n < a[i - 1])
                {
                    tmp = a[i - 1];
                    a[i - 1] = a[i];
                    a[i] = tmp;
                }
            }
            Print(a);
        }
    }
}