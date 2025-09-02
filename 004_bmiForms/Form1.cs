using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmiForms
{
    public partial class bmi : Form
    {
        public bmi()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)　//버튼 더블클릭시 생성
        {
            double w = double.Parse(txtW.Text); //textbox에 입력된 값을 double 형으로 변환하여 
                                                // 몸무게 변수에 저장.
            double h = double.Parse(txtH.Text)/100;//동일하게 키를 저장, bmi계산할때 편하게 하기 위해
                                                    //100으로 나누어서 저장한다.

            double bmi = w / (h * h);　//bmi 공식을 사용하여 bmi 변수에 저장한다.

            lblBMI.Text = "BMI = " + bmi.ToString("#.##"); //Label에 bmi를 출력시키기 위해 문자로 바꾸어 출력시킨다.
                                                           //소수점 형식을 지정하여 출력시킨다.

            if ( bmi <20) //만약 bmi가 20보다 작다면
            {
                lblres.Text = "판정 = " + "저체중"; //판정 라벨에 저체중을 출력
                pictureBox1.BackColor = Color.Blue; //픽쳐박스의 색깔을 파랑으로 출력
            }
            else if (bmi < 25)//만약 bmi가 25보다 작다면
            {
                lblres.Text = "판정 = " + "정상체중";//판정 라벨에 정상체중을 출력
                pictureBox1.BackColor = Color.Green;//픽쳐박스의 색깔을 초록으로 출력
            }
            else if (bmi < 30)//만약 bmi가 30보다 작다면
            {
                lblres.Text = "판정 = " + "경도비만";//판정 라벨에 경도비만을 출력
                pictureBox1.BackColor = Color.Yellow;//픽쳐박스의 색깔을 노랑으로 출력
            }
            else if (bmi < 40)//만약 bmi가 40보다 작다면
            {
                lblres.Text = "판정 = " + "비만";//판정 라벨에 비만을 출력
                pictureBox1.BackColor = Color.Orange;//픽쳐박스의 색깔을 주황으로 출력
            }
            else //만약 bmi가 40보다 높다면
            {
                lblres.Text = "판정 = " + "고도비만";//판정 라벨에 고도비만을 출력
                pictureBox1.BackColor = Color.Red;//픽쳐박스의 색깔을 빨강으로 출력
            }

        }

        private void bmi_Load(object sender, EventArgs e)
        {

        }

        private void lblBMI_Click(object sender, EventArgs e)
        {

        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
