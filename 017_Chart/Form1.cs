using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적"); //차트의 제목을 입력합니다.
            Random r = new Random(); //랜덤 변수를 생성합니다.
            for(int i = 0; i < 10; i++) 
            {
                chart1.Series[0].Points.Add(r.Next(101)); //차트영역에 표시되는 첫번째 데이터에 10개의 0~100까지의 랜덤한 숫자를 넣습니다
            }
            chart1.Series[0].LegendText = "비주얼\n프로그래밍"; //차트의 범례를 비주얼프로그래밍 으로 입력합니다.
            //170장
        }
    }
}
