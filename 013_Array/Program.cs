namespace _013_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //정수배열 {1,2,3} 만들기
            int[] a = { 1, 2, 3 }; //만들면서 초기화시킵니다.
            int[] b = new int[3] { 1, 2, 3 }; //3개짜리라고 먼저 정의한 후 정수배열을 만들고 나서 초기화합니다.
            int[] c = new int[] { 1, 2, 3 }; //배열의 크기를 지정하지 않은 상태에서 초기화시킵니다.
            int[] d = new int[3]; //배열의 크기만 지정해놓습니다.
            d[0] = 1; 
            d[1] = 2;
            d[2] = 3; //배열 각각의 위치에 숫자를 넣습니다.

            Console.Write("a[] : "); //배열을 확인하기 위해 출력시킵니다
            foreach(int i in a) //반복문을 사용하여 배열의 각 요소를 한개씩 출력시킵니다.
            {
                Console.Write(i + " "); //요소들을 한칸씩 띄어쓰기 하며 출력시킵니다.
            }
            Console.WriteLine(); //마지막으로 한줄을 띄어쓰기 위해 WriteLine()을 사용합니다.

            Console.Write("b[] : "); //위와 동일하게 출력시킵니다.
            foreach (int i in b) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("c[] : ");//위와 동일하게 출력시킵니다.
            foreach (int i in c)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("d[] : ");//위와 동일하게 출력시킵니다.
            foreach (int i in d)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            string[] s = { "abc", "bcd", "cde" }; //string 배열을 생성합니다.
            Console.Write("s[] : "); //위와 동일하게 출력시키지만
            foreach (string i in s) //문자열 배열이라는 점이 다릅니다.
                Console.Write(i + " "); //하지만 방식은 동일합니다.
            Console.WriteLine();

           //List 배열을 생성시킵니다.
            List<int> la = new List<int>();//List 배열을 생성하기 위한 코드입니다.
            la.Add(10);//배열을 생성한 후에 Add를 사용하여 숫자를 넣습니다
            la.Add(20); //동일하게 숫자를 입력합니다
            la.Add(3); //동일하게 숫자를 입력합니다

            la.Sort(); //리스트를 정렬하는 명령어입니다.

            Console.Write("List<int> la : "); //위와 동일하게 출력시킵니다.
            foreach(int i in la)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}

//List<T>, 교과서 103장