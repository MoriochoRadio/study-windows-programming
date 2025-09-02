using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e) //로그인 버튼 더블클릭시 생성
        {
            if(txtID.Text == "abcd" && txtPW.Text == "1234") //만약 사용자가 아이디를 "abcd", 비밀번호를 "1234" 입력 시
            {                                                   
                txtRes.Text = "로그인 성공!"; //로그인 성공 이라는 메세지를 결과 텍스트박스에 출력합니다.
            }
            else //만약 아이디, 비밀번호를 다르게 입력했을 시에
            {
                txtRes.Text = "로그인 실패!"; // 결과 텍스트박스에 메세지를 출력합니다.
            }
        }
    }
}
