using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _029_WpfLogin
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) //로그인버튼을 눌렀을 때의 이벤트를 처리
        {
            if (txtId.Text == "abcd" && txtPassword.Password == "1234") //만약 아이디와 비밀번호를 설정한대로 입력했다면
                MessageBox.Show("Login success"); //성공했다는 메세지를 출력하고
            else //다르다면 
                MessageBox.Show("Login Fail"); //로그인 실패 메세지를 출력한다

        }
    }
}
