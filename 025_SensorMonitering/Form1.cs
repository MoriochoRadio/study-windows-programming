using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //차트 그리기를 위한 네임스페이스

namespace _025_SensorMonitering
{
    public partial class Form1 : Form
    {
        SerialPort sPort = null; 
        private double xCount = 50;
        //List<SensorData> myData = new List<SensorData>();

        //시뮬레이션 용
        Timer t = new Timer();
        Random r = new Random();

        

        public Form1()
        {
            InitializeComponent();

            foreach(var ports in SerialPort.GetPortNames())
                comboBox1.Items.Add(ports);
            comboBox1.Text = "Select Port";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1023;

            InitSetting();
            ChartSetting();
        }

        private void ChartSetting()
        {
            chart1.Titles.Add("조도");
            chart2.Titles.Add("온도/습도");
            
            chart1.Series.Clear();
            chart1.Series.Add("lumi");
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = xCount;
            chart1.ChartAreas[0].AxisX.Interval = xCount / 4;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 800;
            chart1.ChartAreas[0].AxisY.Interval = 200;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle= ChartDashStyle.Dash;

            chart1.ChartAreas[0].BackColor = Color.Black;



            chart2.Series.Clear();
            chart2.Series.Add("temp");
            chart2.Series.Add("humid");

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = xCount;
            chart2.ChartAreas[0].AxisX.Interval = xCount / 4;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisY.Interval = 20;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart2.ChartAreas[0].BackColor = Color.Black;

            //시리즈 디자인
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart2.Series[0].Color = Color.LightBlue;
            chart2.Series[0].BorderWidth = 2;
            chart2.Series[0].ChartType = SeriesChartType.Line;

            chart2.Series[1].Color = Color.Orange;
            chart2.Series[1].BorderWidth = 2;
            chart2.Series[1].ChartType = SeriesChartType.Line;
        }

        private void InitSetting()
        {
            btnPortvalue.BackColor = Color.Blue;
            btnPortvalue.ForeColor = Color.White;
            btnPortvalue.Text = "";
            btnPortvalue.Font = new Font("맑은 고딕",12,FontStyle.Bold);

            lblConnectiontime.Text = "Connection time: ";
            txtCount.TextAlign = HorizontalAlignment.Center;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int value = r.Next(800);
            int temp = r.Next(35);
            int humi = r.Next(30, 90);

            string s = string.Format("{0} {1} {2}", temp, humi, value);
            ShowValue(s);
        }

        static int counter = 0;
        static int skip = 0;

        private void ShowValue(string s) //값을 표시하는 메서드
        {

            counter++; //카운터를 1 증가시킨다 호출 횟수를 누적시킨다.
            listBox1.Items.Add(s); // 문자열 s를 리스트박스에 추가한다
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  //리스트박스에서 가장 최근 추가된 항목을 선택한다

            if (++skip < 3) //처음 통신되어 넘어오는 데이터 3개를 스킵한다
                return;
            else
                skip = 3;

            string[] sub = new string[3]; //데이터를 저장할 문자열 배열을 생성한다
            sub = s.Split(' '); //공백을 기준으로 나누어 배열에 저장한다

            double temp = 0; //온도
            double humi = 0; //습도
            int lumi = 0; //조도

            temp = double.Parse(sub[0]); //배열의 요소들을 실수로 변환시켜준다
            humi = double.Parse(sub[1]);
            lumi = int.Parse(sub[2]);

            progressBar1.Value = lumi; //프로그레스바의 값을 조도로 설정한다.
            chart1.Series[0].Points.Add(lumi); //시리즈에 각각 값을 추가해준다

            chart2.Series[0].Points.Add(temp);
            chart2.Series[1].Points.Add(humi);

            //차트에 스크롤 기능 추가
            chart1.ChartAreas[0].AxisX.Minimum = 0; //x축의 최소값을 0으로 한다.
            chart1.ChartAreas[0].AxisX.Maximum = (counter >= xCount) ? counter : xCount;
            //X축의 최대값을 counter 가 xCount보다 커지면 counter로 설정한다.
            if (counter > xCount) //만약 counter가 최대값보다 커지면
            {
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(counter - xCount, counter);// chart1의 X축을 스크롤한다.
                chart2.ChartAreas[0].AxisX.ScaleView.Zoom(counter - xCount, counter);// chart2의 X축을 스크롤한다.
            }

            chart2.ChartAreas[0].AxisX.Minimum = 0; //차트 2 또한 동일하게 설정한다.
            chart2.ChartAreas[0].AxisX.Maximum = (counter >= xCount) ? counter : xCount;
        }

        private void 끝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Stop(); // 타이머 t를 정지시킨다.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sPort != null) //sPort가 이미 설정되었다면?
                return; //메서드 실행을 중지한다
            ComboBox cb = sender as ComboBox; //(ComboBox)sender //콤보박스 cb에 sender 를 설정한다
            sPort = new SerialPort(cb.SelectedItem.ToString()); //serialport 객체를 생성하고 콤보박스에서 선택된 포트로 둔다
            sPort.Open();//포트를 연다
            sPort.DataReceived += SPort_DataReceived; //datareceived를 시작한다.

            btnDisconnect.Enabled = true; //Disconnect 버튼을 활성화한다.
            btnConnect.Enabled = false; //Connect 버튼을 비활성화한다.
        }

        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           string s = sPort.ReadLine();
            this.BeginInvoke(new Action(() => { ShowValue(s); })); 
        }
    }
}
