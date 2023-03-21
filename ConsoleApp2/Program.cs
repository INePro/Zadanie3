namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String v = Console.ReadLine();
            string[] chArr = v.Split();
            int N = Convert.ToInt32(chArr[1]);
            char[,] c = new char[26,1600];
            c[0,0]= Convert.ToChar(chArr[0]);


            int k, n;
            for (int i = 0; i < N; i++)
            {
                k = 0;
                n = 0; 
                for (int j = 0; c[i, j] != '\0'; j++)
                {
                    k++;
                    if (c[i, j + 1] != c[i, j])
                    {
                        c[i + 1, n] = Convert.ToChar(k + 48); 
                        c[i + 1,n + 1] = c[i, j];
                        n += 2;
                        k = 0;
                    }
                }
            }
            for (int i = 0; c[N-1, i] != '\0'; i++)
            {
                Console.Write(c[N-1,i]);
            }
        }
    }
}