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

namespace _019_Math
{
    public partial class Form1 : Form
    {
        bool flag = false; //참 거짓 변수를 만들어놓습니다.
        public Form1()
        {
            InitializeComponent();
        }

        //그냥외우기
        protected override void OnPaint(PaintEventArgs e)//직접 차트의 디자인을 수정하기 위한 메서드
        {
            //차트의 배경색
            chart1.ChartAreas[0].BackColor = Color.Black; // 차트의 배경색을 지정합니다.

            chart1.ChartAreas[0].AxisX.Minimum = -20; //차트영역의 X축의 최소 범위를 설정합니다.
            chart1.ChartAreas[0].AxisX.Maximum = 20; //차트영역의 X축의 최대 범위를 설정합니다.
            chart1.ChartAreas[0].AxisX.Interval = 2; //차트영역의 X축 간격을 2로 설정합니다.
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray; //x차트의 그리드 라인의 색상을 설정합니다.
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash; //그리드 라인을 점선으로 설정합니다.

            chart1.ChartAreas[0].AxisY.Minimum = -2;//차트영역의  Y축의 최소 범위를 설정합니다.
            chart1.ChartAreas[0].AxisY.Maximum = 2;//차트영역의 Y축의 최대 범위를 설정합니다.
            chart1.ChartAreas[0].AxisY.Interval = 0.5;//Y축 간격을 0.5로 설정합니다.
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray; //그리드 라인의 색상을 설정합니다.
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;//그리드 라인을 점선으로 설정합니다.

            // Series[0] : sin(x)/x //차트의 첫번째 데이터를 설정합니다.
            chart1.Series[0].ChartType = SeriesChartType.Line; //차트 유형을 선형으로 설정합니다.
            chart1.Series[0].Color = Color.LightGreen; //시리즈 선 색상을 설정합니다.
            chart1.Series[0].BorderWidth = 2; //선 두께를 2로 설정합니다.
            chart1.Series[0].LegendText = "sin(x)/x"; //범례의 텍스트를 설정합니다.

            // Series[1] : cos(x)/x  //차트의 두번째 데이터를 설정합니다.
            if(chart1.Series.Count == 1) //하나의 시리즈만 존재 할 시에 시리즈를 추가하도록 합니다.
                chart1.Series.Add("cos"); //시리즈를 추가합니다.
            chart1.Series[1].ChartType = SeriesChartType.Line; //추가한 시리즈의 차트 유형을 선으로 설정합니다.
            chart1.Series[1].Color = Color.Orange; //선의 색상을 설정합니다.
            chart1.Series[1].BorderWidth = 2; //선 두께를 2로 설정합니다.
            chart1.Series[1].LegendText = "cos(x)/x"; //범례의 텍스트를 설정합니다.

            //Series에 데이터를 추가
            if (flag == false) //데이터를 차트에 단 한 번만 추가하도록 참거짓 변수를 조건문에서 사용합니다
            {
                flag = true; //데이터가 추가되므로 참으로 바꾸어 중복 추가되지 않도록 합니다.
                for (double x = -20; x <= 20; x += 0.1) //0.1씩 증가하며 데이터를 추가합니다.
                {
                    double y = Math.Sin(x) / x; //첫번째시리즈의 Y값을 계산하여 추가합니다.
                    chart1.Series[0].Points.AddXY(x, y); 

                    y = Math.Cos(x) / x; //두번째시리즈의 Y값을 계산하여 추가합니다.
                    chart1.Series[1].Points.AddXY(x, y);
                }
            }
            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
