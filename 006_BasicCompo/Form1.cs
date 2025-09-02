using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_BasicCompo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//버튼을 클릭할시
        {
            lblRes.Text = txtbName.Text + "님! 안녕하세요"; // 텍스트박스에 입력한 텍스트에 "님 안녕하세요" 문장을
        }                                                   //붙여서 출력시킨다.

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
