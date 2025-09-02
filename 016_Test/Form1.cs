using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //버튼 클릭시 이벤트
        {
            string result = ""; //결과값 저장하기 위한 문자열 변수 생성
            RadioButton[] rbC = { rb1, rb2, rb3, rb4 }; //라디오버튼 배열 생성
            foreach (var item in rbC) //반복문을 이용
            {
                if (item.Checked) //만약 라디오버튼이 체크되어있을 시에
                {
                    result += item.Text; //결과문자열 변수에 라디오버튼의 문자 저장
                }
            }


            MessageBox.Show(result +"\n"+comboBox1.SelectedItem.ToString()+"학년"+"\n"+ textBox1.Text + "\n" + textBox2.Text + "\n" + comboBox2.SelectedItem.ToString(), "학생정보", MessageBoxButtons.OK);
            //메세지박스를 만들어 학과와 학년 학번 이름 주거를 각각 출력시키고, 제목을 쓰고, 확인 버튼을 생성한다.
        }

        private void Form1_Load(object sender, EventArgs e) //폼이 로드되었을 때
        {
                        
            int[] grade = { 1, 2, 3, 4 }; //학년을 저장한 정수배열
            String[] home = { "기숙사", "자취", "통학" }; //거주지를 저장한 문자열 배열

            comboBox1.Items.Clear(); //콤보박스를 초기화한다
            foreach (var item in grade) //반복문을 활용하여
            {
                comboBox1.Items.Add(item); //콤보박스1에 아이템들을 집어넣는다.
            }

            comboBox2.Items.Clear();
            foreach (var i in home) //동일하게 콤보박스 2에 아이템들을 집어넣는다.
            {
                comboBox2.Items.Add(i);
            }

            //for(int i = 1; i <= 4; i++)
            //{
            //    comboBox1.Items.Add(i);
            //}  이렇게 해도 됨

        }
    }
}
