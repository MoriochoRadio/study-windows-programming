using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_DClock
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();         
            this.Text = "My Form Clock";        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            timer1.Enabled = true; //타이머를 시작시킵니다.
            timer1.Interval = 1000; //타이머의 인터벌을 1초로 설정합니다.
            timer1.Tick += Timer1_Tick; //1초마다 Timer1_Tick 함수를 호출합니다.

            lblDate.Font = new Font("맑은 고딕", 16, FontStyle.Bold | FontStyle.Italic); //날짜를 표시하는 라벨의 폰트와 크기, 스타일을 지정합니다.
            lblDate.ForeColor = Color.DarkOrange; //폰트의 색상을 설정합니다.

            lblTime.Font = new Font("맑은 고딕", 32, FontStyle.Bold); //시간을 표시하는 라벨의 폰트와 크기, 스타일을 지정합니다.
            lblTime.ForeColor = Color.DarkBlue; //폰트의 색상을 설정합니다.
        }

        private void Timer1_Tick(object sender, EventArgs e) //Timer1_Tick 함수를 세부적으로 설정합니다.
        {
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일"); //날짜를 표시하는 라벨에 현재 날짜를 문자열로 나타냅니다.
            lblTime.Text = DateTime.Now.ToString("tt h:mm:ss"); //시간을 표시하는 라벨에 현재 시각을 문자열로 나타냅니다.

            lblDate.Location = new Point(ClientSize.Width / 2 - lblDate.Width / 2, ClientSize.Height / 2 - lblDate.Height / 2 - 30);
            //날짜를 나타내는 라벨의 위치를 좌표를 지정하여 중앙으로 조정합니다.
            lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2, ClientSize.Height / 2 - lblTime.Height / 2 + 20);
            //시간을 나타내는 라벨의 위치를 좌표를 지정하여 중앙으로 조정합니다.
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }   //OnPaint 는 페인트 이벤트가 발생할때마다 한다는의미 (최대화,화면켜짐 이럴때)
}
