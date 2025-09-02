using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _024_TwoForms
{
    
    public partial class Form2 : Form
    {

        Form1 f = null; //form1을 form 클래스로 null인 상태로 생성한다.

        public Form2(Form1 form) //form2의 생성자로 form1을 받아서
        {
            InitializeComponent();
            f = form; //form1을 만든다.
        }

        private void button1_Click(object sender, EventArgs e)//form1을 표시하는 버튼을 눌렀을 경우에
        {
            
            f.Show();//form1을 보여주게 한다.
        }

        private void button2_Click(object sender, EventArgs e)//form1 타이틀을 변경하는 버튼을 눌렀을 경우
        {
            f.Text = textBox1.Text; //form1의 텍스트를 변경한다.
        }

        private void button3_Click(object sender, EventArgs e)//form1의 레이블 변경 버튼을 눌렀을 경우
        {
            f.label1.Text = "label1.Text = " + textBox1.Text; //form1의 레이블을 변경한다. 이때 form1의 레이블의 modifires 속성을 public으로 변경하여야 접근이 가능하다.
        }

        private void button4_Click(object sender, EventArgs e)//common class 값을 지정하는 버튼을 눌렀을 경우
        {
            Common.Str = textBox1.Text; //common 클래스의 string 변수에 세터를 사용해 문자열값을 저장한다.
                                        //이 때에도 위와 같이 속성을 public으로 변경해야하는 번거로움을 해결할 수 있다.
        }
    }
}
