namespace ParcurgereLatime_BackTracking
{
    //Lab 30.05.2022
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] s = new int[n];
            BK1(0, n, s);
            Console.WriteLine("Done.");
        }
        public static void BK1(int k, int n, int[] s)
        {//produs cartezian
            if (k >= n)
            {
                bool ok = false;
                for (int i = 2; i < n; i++)
                {
                    if (s[i - 2] == s[i - 1] && s[i - 1] == s[i])
                    {
                        ok = true;

                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    s[k] = i;
                    BK1(k + 1, n, s);
                }
            }
        }
        public static void BK3(int k, int n, int[] s, bool[] b)
        {//permutari (n!)
            if (k >= n)
            {
                int sl1 = s[0] + s[1] + s[2];
                int sl2 = s[3] + s[4] + s[5];
                int sl3 = s[6] + s[7] + s[8];
                for (int i = 0; i < n; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BK3(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}