using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_AnalogClock
{
    public partial class Form1 : Form
    {
        //멤버변수(필드)
        Graphics g; //그래픽을 그리기 위하여 생성합니다.
        bool aClock_Flag = true; //디지털 시계와 아날로그 시계를 표시하는 기능을 위한 bool 변수를 생성합니다.
        Point center; //중심점을 미리 생성합니다.
        int radius; //시계의 반지름 변수입니다.
        int hourHand; //시침의 길이 변수입니다.
        int minHand; //분침의 길이 변수입니다.
        int secHand; //초침의 길이 변수입니다.

        const int clitentSize = 300; //Form의 크기를 지정합니다.
        const int clockSize = 200; //시계의 판넬 크기를 지정합니다.

        Font fDate; //날짜 폰트(dClockSetting() 에서 만들 것임) 미리 생성하여 줍니다.
        Font fTime; //시간 폰트
        Brush bDate; //날짜 색깔
        Brush bTime; //시간 색깔

        Point panelCenter; //패널 중심점을 미리 생성합니다.

        public Form1() //생성자
        {
            InitializeComponent();

            //this는 지금 만들고있는 Form을 의미합니다.
            //영역의 크기를 설정합니다. 원의 크기가 밖으로 나오지 못하도록 추가적인 영역을 지정합니다. 
            this.ClientSize = new Size(clitentSize, clitentSize+menuStrip1.Height); //ClientSize를 만듦
            this.Text = "My Form Clock"; //제목을 지정합니다.
            
            panel1.Width =clockSize; //패널의 넓이를 지정합니다.
            panel1.Height =clockSize; //패널의 높이를 지정합니다.
            panel1.Location = new Point(clitentSize/2 - clockSize/2, clitentSize / 2 - clockSize / 2 + menuStrip1.Height  );
            //x좌표와 y좌표 (패널의 사각형의 왼쪽 위가 기준점임) 지정합니다.
            
            panel1.BackColor = Color.WhiteSmoke; //패널의 배경색을 지정합니다.

            g = panel1.CreateGraphics(); //그래픽 객체를 생성합니다.

            // 각종 설정을 위한 함수를 호출합니다.
            aClockSetting(); // 아날로그 시계 함수
            dClockSetting(); // 디지털 시계 함수
            TimerSetting(); //타이머 설정 함수

             

            panelCenter = new Point(clockSize / 2, clockSize / 2);//패널의 센터를 정의합니다.

        }

        private void aClockSetting() //아날로그 시계 함수입니다.
        {
            center = new Point(clitentSize/2, clitentSize/2); //중심점을 설정합니다.
            radius = clockSize/2; //반지름을 설정
            // 시침, 분침, 초침의 길이를 설정합니다.
            hourHand = (int)(radius*0.45); //HourHand는 double 이라서 형변환을 해줍니다.
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);
        }

        private void TimerSetting() 
        {
            Timer t = new Timer(); //타이머 생성

            t.Interval = 1000; //타이머의 간격을 1초로 지정합니다
            t.Tick += T_Tick; //1초에 한번씩 T_Tick 함수를 호출합니다.
            t.Start(); //타이머를 시작합니다.
        }

        //1초에 한번씩 수행되는 Tick 이벤트 처리 함수
        private void T_Tick(object sender, EventArgs e) //핵심
        {
            DateTime c = DateTime.Now; //현재 시간을 가져옵니다.

            panel1.Refresh(); //패널을 지운다

            if(aClock_Flag == true) //아날로그 시계를 선택했을 경우에 실행합니다. (기본실행)
            {
                DrawClockFace(); //시계판을 그립니다.

                //시간에 따른 시계바늘들의 각도를 계산합니다.


                //시침의 각도
                double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;//1시간에 30도씩 돌아감
                //분침의 각도
                double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180; //1분에 6도씩 돌아감
                //초침의 각도
                double radSec = c.Second * 6 * Math.PI / 180;
                DrawHands(radHr,radMin,radSec); //시계바늘을 그립니다.

            }
            else //디지털 시계
            {
                string date = DateTime.Today.ToString("D"); //자세한 날짜
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}",c.Hour,c.Minute,c.Second);
                
                g.DrawString(date, fDate, bDate, new Point(10, 70));
                g.DrawString(time, fTime, bTime, new Point(10, 90));    
            }
        }

        //시계바늘그리기
        private void DrawHands(double radHr, double radMin, double radSec)
        {
            //시침 (위치,색상,두께를 지정)
            DrawLine(0, 0, (int)(hourHand * Math.Sin(radHr)), (int)(hourHand * Math.Cos(radHr)), Brushes.RoyalBlue, 8);
            //분침
            DrawLine(0, 0, (int)(minHand * Math.Sin(radMin)), (int)(minHand * Math.Cos(radMin)), Brushes.SkyBlue, 6);
            //초침
            DrawLine(0, 0, (int)(secHand * Math.Sin(radSec)), (int)(secHand * Math.Cos(radSec)), Brushes.OrangeRed, 4);
            //배꼽
            int coreSize = 16; //원의 크기를 지정합니다.
            Rectangle r = new Rectangle(panelCenter.X - coreSize/2, panelCenter.Y - coreSize/2, coreSize,coreSize);
            //좌표, 너비, 높이
            //사각형의 위치와 크기를 지정합니다.
            g.FillEllipse(Brushes.Gold, r); //원을 채웁니다.
            g.DrawEllipse(new Pen(Brushes.Green, 3), r); //원의 테두리를 그립니다.

            
        }

        // 시계바늘을 그리는 함수입니다.
        private void DrawLine(int x1, int y1, int x2, int y2, Brush brush, int thick)
        {
            Pen p = new Pen(brush, thick); //펜의 색상과 두께를 지정합니다.
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round; //선의 끝 모양을 둥글게 만들어줍니다.
            
            g.DrawLine(p, panelCenter.X + x1, panelCenter.Y + y1, panelCenter.X + x2, panelCenter.Y - y2);// 선을 그립니다.
        }

        private void DrawClockFace() //시계판 그리기
        {
            const int penWidth = 30; //시계 테두리 선의 두께

            Pen p = new Pen(Brushes.LightSteelBlue, penWidth); //30두께로 그리는 펜을 만듭니다.
            //사각형(패널)을 지정해 놓고 거기에 내접하는 Eliipse 를 펜으로 그려줍니다.
            //시작하는 점과 width, height를 넣습니다.
            g.DrawEllipse(p, penWidth/2, penWidth/2, clockSize- penWidth, clockSize- penWidth);  //좌표,너비,높이

            //penWidth/2, penWidth/2: 타원의 시작 위치를 지정하는 x, y 좌표입니다. 여기서 penWidth/2는 펜의 두께의 절반 값을 각각 x, y 시작점으로 사용함으로써 타원이 캔버스 중앙에 정확하게 위치하도록 조정합니다.
            //clockSize - penWidth, clockSize - penWidth: 타원의 너비와 높이를 지정합니다. clockSize에서 penWidth를 빼는 것은 타원의 전체 크기에서 펜 두께만큼 감소시켜 펜이 그림 영역 바깥으로 벗어나지 않도록 하기 위함입니다.
        }



        private void dClockSetting()
        {

            fDate = new Font("맑은 고딕", 12, FontStyle.Bold);
            fTime = new Font("맑은 고딕", 30, FontStyle.Bold | FontStyle.Italic);
            bDate = Brushes.OrangeRed;
            bTime = Brushes.SteelBlue;
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClock_Flag = true;
        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClock_Flag = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //protected override void OnPaint 외우기

    }
}
