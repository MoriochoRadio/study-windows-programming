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

namespace _030_CheckBox
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckBox[] cbs;
        public MainWindow()
        {
            InitializeComponent();

            cbs = new CheckBox[] { cbC, cbCpp, cbCs, cbPy, cbJava };
        }

        

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string str = string.Empty; //string s = "";

            foreach (var cd in cbs)
            {
                if (cd.IsChecked == true)
                    str += cd.Content + ", ";
            }
            MessageBox.Show(str + "Selected", "선호언어");
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
