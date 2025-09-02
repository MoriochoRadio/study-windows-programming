using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_RadioBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rbKorea.Checked) //rbKorea.Checked == True 랑 똑같은 말임
            {
                result += "국적 : 대한민국\n";
            }
            else if (rbChina.Checked)
            {
                result += "국적 : 중국\n";
            }
            else if (rbJapan.Checked)
            {
                result += "국적 : 일본\n";
            }
            else if (rbEtc.Checked)
            {
                result += "국적 : 그 외의 국가\n";
            }

            if (rbMale.Checked) //교과서에 변수로 하는법 보기
            {
                result += "성별: 남성";
            }
            else if (rbFemale.Checked)
            {
                result += "성별: 여성";
            }

            MessageBox.Show(result, "result"); 
        }
    }
}
