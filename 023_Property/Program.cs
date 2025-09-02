using System;

namespace MyApp 
{

    class Rectangle //클래스를 생성합니다.
    {
        private double width; //Private로 객체를 두개 생성합니다.
        private double height;

        public double GetWidth() //width를 가져오는 함수를 생성합니다.
        {
            return width;
        }
        public void SetWidth(double width)//width를 조건에 만족할 시에 변경해주는 함수를 만듭니다.
        {
            if (width > 0)// 만약 0보다 크다면 변경해줍니다.
            {
                this.width = width;
            }
        }
        public double GetHeight() //height를 가져오는 함수를 만듭니다.
        {
            return height;
        }
        public void SetHeight(double height) //조건을 만족할경우에 height 값을 변경해주는 함수를 만듭니다
        {
            if (height > 0) //0보다 클 시에 변경해줍니다.
            {
                this.height = height;
            }
        }

        public double GetArea() //넓이를 가져오는 함수를 만듭니다.
        {
            return width * height; 
        }

    }

    class RectWithProp //가장 간단한 속성의 클래스를 만듭니다
    {
        public double Width { get; set; } //값을 가져오는 게터와 설정하는 메소드 세터를 제일 쉽게 만드는 방법입니다.
        public double Height { get; set; } //쉬운 대신 public 으로 설정됩니다.

        public double GetArea() { return Width * Height; } //위와 동일하게 넓이를 반환하는 함수입니다.
    }

    class RectWithPropFull //속성에 조건을 붙였을 때의 클래스 예시를 만듭니다.
    {
        private int width; //private로 객체를 생성합니다.
        public int Width //한번에 게터와 세터를 설정하며 조건문을 달아줍니다.
        {
            get { return width; }
            set { if(value > 0) width = value; }
        }

        private int height;//private로 객체를 생성합니다.

        public int Height//동일하게 한번에 게터와 세터를 설정하며 조건문을 달아줍니다.
        {
            get { return height; }
            set { if(value > 0) height = value; }
        }

        public double GetArea() { return width * height; } //넓이를 반환하는 함수입니다.
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(); //함수 객체를 생성합니다.
            r.SetWidth(10); //인스턴트 메소드 함수를 이용해 값을 설정합니다.
            r.SetHeight(10);
            Console.WriteLine(r.GetArea()); //넓이를 불러오는 함수를 사용해 출력합니다

            RectWithProp r1 = new RectWithProp();//함수 객체를 생성합니다.
            r1.Width = 10; //속성(Property)를 사용해 쉽게 값을 변경할 수 있습니다.
            r1.Height = 10;  
            Console.WriteLine(r1.GetArea());//넓이를 불러오는 함수를 사용해 출력합니다

            RectWithPropFull r2 = new RectWithPropFull();//함수 객체를 생성합니다.
            r2.Width = 10; //속성(Property)를 사용해 쉽게 값을 변경할 수 있습니다 조건문까지 추가된 세터입니다.
            r2.Height = 10;
            Console.WriteLine(r2.GetArea());//넓이를 불러오는 함수를 사용해 출력합니다
        }
    }
}