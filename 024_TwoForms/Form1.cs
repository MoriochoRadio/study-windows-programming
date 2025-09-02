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
    
    public partial class Form1 : Form
    {
        Form2 f = null; //Form2 를 생성하기 위한 form 클래스의 변수를 먼저 null로 만듭니다.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //form2 보이기 버튼을 눌렀을 경우
        {

            if(f == null) //Form2가 없을 때만 만들기 위해 조건문을 만든다
                f= new Form2(this); //만약 폼이 한개도 없다면 Form2의 생성자에게 form1을 넘겨주고 form2를 만든다.
            f.Show(); //만든 form2를 보여준다
            this.Hide(); //지금 띄워져있는 form1 을 숨긴다.
        }

        private void button2_Click(object sender, EventArgs e) //form2 텍스트 가져오기 버튼을 눌렀을 경우
        {
            label1.Text = "label1.Text = " + f.textBox1.Text; //label1의 텍스트는 form2의 textbox1의 텍스트에서 가져온다.
                                                                //두번째 form의 textbox의 Modifires를 public으로 바꿔야 접근할수 있다.
        }

        private void button3_Click(object sender, EventArgs e) //common 클래스 값 가져오기를 눌렀을 경우
        {
            label1.Text = "label1.Text = "+ Common.Str; //form2에서 common클래스의 세터로 저장해 놓은 string을 게터로 가져온다.
                                                        //이것은 위의 public으로 속성을 바꿔야하는 번거로움을 해결할수 있다.
        }
    }
}
