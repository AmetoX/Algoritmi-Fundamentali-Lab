using System.IO;
namespace Lab_06_06_BK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine();
            int n = 16;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BK(0, n, s, b);
            
        }
        static void BK(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
               // int sl1 = s[0] + s[1] + s[2] + s[3]; //suma pe linia 1
                //int sl2 = s[4] + s[5] + s[6] + s[7];
               // int sl3 = s[8] + s[9] + s[10] + s[11];
               // int sl4 = s[12] + s[13] + s[14] + s[15];

               // int sc1 = s[0] + s[4] + s[8] + s[12]; // suma pe coloana 1
                //int sc2 = s[1] + s[5] + s[9] + s[13];
               // int sc3 = s[2] + s[6] + s[10] + s[14];
                //int sc4 = s[3] + s[7] + s[11] + s[15];

                //int sd1 = s[0] + s[5] + s[10] + s[15]; // suma pe diagonala principala
                //int sd2 = s[3] + s[6] + s[9] + s[12];

                //if (sl1 == sl2 && sl1 == sl3 && sl1 == sl4 && sl1 == sc1 && sl1 == sc2 && 
                    //sl1 == sc3 && sl1 == sc4 && sl1 == sd1 && sl1 == sd2)
                //{
                    int l = 0;
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                        l++;
                        if (l == 4)
                        {
                           Console.WriteLine();
                            l = 0;
                        }
                    }
                    Console.WriteLine();
                //}
            }
            else
            {
                for(int i =0;i< n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BK(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}