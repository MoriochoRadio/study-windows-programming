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

namespace _034_SnakeBite
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e) //플레이 버튼을 눌렀을 경우
        {
            Game game = new Game(); //따로 만들어둔 Game 화면에 대한 게임 객체를 새로 만들어줍니다.
            game.Show(); //게임 창을 새로 띄웁니다.
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e) //종료 버튼을 눌렀을 경우에는
        {
            this.Close(); //종료합니다.
        }

    }
}
