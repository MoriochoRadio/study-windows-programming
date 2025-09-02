using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1) x 에서 y 까지의 합, 홀수의 합, 역수의 합   
            Console.WriteLine("x와 y 값 입력");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;
            double sum3 = 0;

            for (int i = x; i <= y; i++)
            {
                sum += i;
                sum3 += 1.0 / i;
                if (i % 2 == 1) 
                    sum2 += i;
                
            }

            Console.WriteLine("합 = {0}, 홀수의 합 = {1}, 역수의 합 = {2}", sum, sum2, sum3);

            //(2) 구구단
            Console.WriteLine("구구단");
            for (int i = 1; i <= 9; i++)
            {
                for(int t = 1; t <= 9; t++)
                {

                    Console.Write(i+"*"+t+"="+i*t+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //(3) x의y승
            Console.WriteLine("x의 y승의 x와 y 값 입력");
            sum = 1;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                sum = sum * x;
            }
            Console.WriteLine(sum);


            //(4) n!

            Console.WriteLine();
            Console.WriteLine("n! 의 n 값 입력");
            int n = int.Parse(Console.ReadLine());
            sum = 1;

            for(int i=1; i<=n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}