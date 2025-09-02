using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random 클래스의 객체 r을 만든다
            Random r = new Random();
            //정육면체모양은 함수들이고 별표있는건 많이쓰는 함수들
            //ppt참고하기
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(r.NextDouble());
            //}

            //20개의 랜덤 숫자를 배열에 저장하고 최대, 최소, 평균을 계산 중요함
            int[] a = new int[20]; //배열 만드는거 외우기 중요함
            for(int i = 0; i<20; i++)
            {
                a[i] = r.Next(1,101);
                Console.WriteLine("Number {0}: {1}", i + 1, a[i]);
            }

            int big = a[0], small = a[0], avg=0;

            for(int i=0; i<20; i++)
            {
                if(big > a[i])
                {
                    big = a[i];
                }

                if(small < a[i])
                {
                    small = a[i];
                }

                avg += a[i];

            }

            avg /= a.Length;

            Console.WriteLine("min = {0}, max = {1}, avg = {2}",big,small,avg);

            Console.WriteLine(big);
            Console.WriteLine(small);
            Console.WriteLine(avg);


            
        }
    }
}

////foreach 쓸 때 주의점
//int[] arr = { 10, 20, 30, 40, 50 };
//for (int i = 0; i < 5; i++)
//    Console.WriteLine(arr[i]);

//foreach (var i in arr)
//    Console.WriteLine(i); //arr[i] 가 아님

////foreach 문장은 배열의 크기를 몰라도 사용할 수 있다. 그래서 배열과 리스트 쓸때 편하다
////Random r = new Random(); 이거 외우기

////65장에서 69장까지 클래스임 