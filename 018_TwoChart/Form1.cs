using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _018_TwoChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적"); //차트1의 제목을 성적으로 입력합니다

            chart1.Series.Add("Series2"); //차트의 시리즈(데이터)를 Series2 로 추가합니다

            chart1.Series[0].LegendText = "수학"; //첫번째 시리즈의 범례를 수학으로 입력합니다.
            chart1.Series[1].LegendText = "영어"; //두번째 시리즈의 범례를 영어로 입력합니다.

            Random r = new Random(); //랜덤 변수를 생성합니다.

            for(int i = 0; i < 10; i++) //10번 반복합니다.
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101)); //첫번째 시리즈의 그래프 X,Y값으로 반복문의 i와 0~100까지의 랜덤한 값을 입력합니다
                chart1.Series[1].Points.AddXY(i, r.Next(101)); //두번째 시리즈의 그래프 X,Y값으로 반복문의 i와 0~100까지의 랜덤한 값을 입력합니다
            }
        }

        //나누어 그리기
        private void button2_Click(object sender, EventArgs e) //버튼2를 클릭하였을 경우입니다.
        {
            //ChartArea1은 디폴트로 존재함, ChartArea2만 생성
            if (chart1.ChartAreas.Count <= 1) //만약 차트의 차트영역이 1개 이하일 경우에 밑의 문장을 실행합니다.
                chart1.ChartAreas.Add("ChartArea2"); //차트영역에 ChartArea2로 영역을 추가합니다.
            chart1.Series[1].ChartArea = "ChartArea2"; //두번째 시리즈값을 ChartArea2 차트영역에 추가합니다.
        }

        //합쳐서 그리기
        private void button1_Click(object sender, EventArgs e) //버튼1을 클릭하였을 경우입니다.
        {
            if(chart1.ChartAreas.Count >= 2) //만약 차트영역이 2개 이상일 경우에 실행합니다.
                chart1.ChartAreas.RemoveAt(1);//차트 영역의 2번째 영역을 제거합니다.
            chart1.Series[1].ChartArea = "ChartArea1"; //두번째 시리즈값을 ChartArea1 에 추가합니다.
        }
    }
}

//ChartAreas[0] -> ChartArea 1
//ChartAreas[1] -> ChartArea 2
//Series[0] -> Series1
//Series[1] -> Series2
