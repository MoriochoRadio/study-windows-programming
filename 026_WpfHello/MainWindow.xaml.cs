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

namespace _026_WpfHello
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
        
        
        // TextBlock 컨트롤의 MouseDown에 대한 매서드
        // 사용자가 텍스트 블록을 마우스로 클릭할 때 호출된다.
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Text Clicked!", "String msg"); //텍스트가 클릭되면 클릭되었다는 메세지를 출력

            if (grid1.Background == Brushes.Orange)//만약 그리드의 배경색이 오렌지라면
            {
                grid1.Background = Brushes.Aqua; //배경색을 아쿠아색으로 변경한다
            }
            else //오렌지가 아닌 다른 색이라면
            {
                grid1.Background= Brushes.Orange; //다시 오렌지색으로 변경한다
            }
        }
    }
}
