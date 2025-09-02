using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkStates = "";
            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 }; //배열 중요

            foreach(var item in cBox) 
            {
                checkStates += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }

            MessageBox.Show(checkStates, "checkStates");

            string summary = "좋아하는 과일은: "; //string.Format("좋아하는 과일은: "); 문자열로 WriteLine 쓸때처럼 쓸려면 Format 쓰면 됨
            foreach(var item in cBox)
            {
                if (item.Checked == true)
                    summary += item.Text + " ";
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
