using System;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.Tickets1());
            Console.WriteLine(program.Tickets2());
            Console.WriteLine(program.Tickets3());
            Console.WriteLine(program.Tickets4()); // Сложность N^4
            Console.ReadKey();
        }

        int Tickets1()
        {
            int q = 0;
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                for (int f = 0; f <= 9; f++)
                                {
                                    if (a + b + c == d + e + f)
                                    {
                                        q++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return q;
        }

        int Tickets2()
        {
            int q = 0;
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        int abc = a + b + c;
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                int de = d + e;
                                for (int f = 0; f <= 9; f++)
                                {
                                    if (abc == de + f)
                                    {
                                        q++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return q;
        }

        int Tickets3()
        {
            int q = 0;
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        int abc = a + b + c;
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                int f = abc - (d + e);
                                if (f >= 0 && f <= 9)
                                {
                                    q++;
                                }
                            }
                        }
                    }
                }
            }
            return q;
        }

        int Tickets4()
        {
            int[] mass = new int[28];
            int q = 0;
            
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        int abc = a + b + c;
                        mass[abc]++;
                    }
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                //Суммируем количество комбинаций.
                q += mass[i] * mass[i];
            }

            return q;
        }
    }
}
