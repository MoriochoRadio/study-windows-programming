using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace _033_Mysql
{
    public partial class MainWindow : Window
    {
        // 사용자가 입력한 값을 저장할 변수들을 만든다
        private string pos; // 직급
        private string dept; // 부서
        private string gender; // 성별
        private string dateEnter; // 입사일
        private string dateExit; // 퇴사일

        // 데이터베이스와 연결할 문자열을 미리 정의한다
        string connStr = "server=localhost; user id=root; password=1234; database=eis_db";
        MySqlConnection conn; // DB 연결을 위한 객체를 만든다

        
        public MainWindow()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr); // MySQL 연결을 위한 객체를 초기화시킨다
            DisplayDataGrid(); // 데이터 그리드에 이미 있는 정보들을 메인화면이 나왔을때 바로 뜨도록 함수를 호출해준다
        }

        // Insert 버튼을 눌렀을 때
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            // 어떤 라디오 버튼을 선택했는지를 gender 변수에 저장한다
            if (rbMale.IsChecked == true)
                gender = "남성";
            else if (rbFemale.IsChecked == true)
                gender = "여성";

            // 입사일과 퇴사일을 선택된 날짜로 설정하고 선택되지 않은 경우 최대값으로 지정해놓는다
            if (dpEnter.SelectedDate != null)
                dateEnter = dpEnter.SelectedDate.Value.Date.ToShortDateString(); //시간이 들어가지 않게 ShortDateString을 사용한다
            if (dpExit.SelectedDate != null)
                dateExit = dpExit.SelectedDate.Value.Date.ToShortDateString();
            else
                dateExit = DateTime.MaxValue.ToShortDateString();

            // 부서와 직급을 콤보박스에서 선택된 값으로 설정한다
            dept = cbDept.Text;
            pos = cbPos.Text;

            // 데이터베이스 연결을 연다
            conn.Open();

            // 내가 만들어 놓은 SQL데이터베이스인 eis_table 에 데이터를 삽입하는 명령어를 저장해놓는다
            string sql = string.Format("INSERT INTO eis_table (name, department, position, gender, date_enter, date_exit, contact, comment) "
                + "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", // 문자열일 때는 홑따옴표로 감싸야 한다 (숫자면 안해도됨)
                txtName.Text, dept, pos, gender, dateEnter, dateExit, txtContact.Text, txtComment.Text);

            // SQL 명령을 실행한다
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() == 1) // 만약 영향을 받은 데이터 로우의 개수가 1개이면 성공 메시지를 표시한다
                MessageBox.Show("성공");

            // 데이터베이스 연결을 닫는다
            conn.Close();

            // 데이터 그리드를 최신화시켜준다
            DisplayDataGrid();
        }

        // 데이터를 업데이트하는 버튼 클릭했을때
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            // 데이터베이스 연결을 연다
            conn.Open();

            // 성별 라디오버튼의 선택을 gender 변수에 저장한다
            if (rbMale.IsChecked == true)
                gender = "남성";
            else
                gender = "여성";

            // 입사일과 퇴사일을 저장한다
            dateEnter = dpEnter.Text;
            dateExit = dpExit.Text;

            try //트라이 캐치를 사용해 오류를 확인할수있다
            {
                // 나의SQL 데이터베이스의 eis_table 에 데이터를 업데이트하는 명령어를 저장해놓는다
                string sql = string.Format("UPDATE eis_table SET name='{0}', department='{1}', position='{2}', gender='{3}', date_enter='{4}', date_exit='{5}', contact='{6}', comment='{7}' WHERE eid={8}", //마지막 eid는 숫자라 ''가 없다
                txtName.Text, cbDept.Text, cbPos.Text, gender, dateEnter, dateExit, txtContact.Text, txtComment.Text, txtEid.Text);

                // 명령을 실행한다
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() == 1) // 영향을 받은 로우의 개수가 1개이면 성공 메시지를 표시한다
                    MessageBox.Show(" 수정 성공 ");
            }
            catch (Exception ex) //오류발생했을경우에 오류메세지를 잡아준다
            {
                // 예외가 발생하면 에러 메시지를 표시한다
                MessageBox.Show(ex.Message);
            }

            // 데이터베이스 연결을 닫는다
            conn.Close();

            // 데이터 그리드를 갱신한다
            DisplayDataGrid();
            
        }

        // 데이터를 삭제하는 버튼 클릭
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // 데이터베이스 연결을 연다
            conn.Open();

            try //트라이캐치로 오류를 확인할수있다
            {
                //  eis_table에 데이터를 삭제하는 명령어를 저장한다
                string sql = string.Format("DELETE FROM eis_table WHERE eid={0}", txtEid.Text);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() == 1) // 영향을 받은 로우의 개수가 1개이면 성공 메시지를 표시한다
                    MessageBox.Show("삭제 성공");
            }
            catch (Exception ex)
            {
                // 예외가 발생하면 에러 메시지를 표시한다
                MessageBox.Show(ex.ToString());
            }

            // 데이터베이스 연결을 닫는다
            conn.Close();

            // 데이터 그리드를 갱신한다
            DisplayDataGrid();
        }

        // 데이터를 로드하는 버튼 클릭
        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            // 데이터 그리드를 갱신
            DisplayDataGrid();
        }

        // 데이터 그리드를 갱신하는 메서드
        private void DisplayDataGrid()
        {
            // 데이터베이스 연결을 연다
            conn.Open();

            // eis_table 에서 모든 데이터를 선택하는 명령어를 저장해놓는다
            string sql = "SELECT * FROM eis_table";

            try
            {
                // MySqlDataAdapter 객체를 만든다 명령어와 연결을 여는 conn을 사용하여 데이터를 가져온다
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                // DataSet 객체를 만든다 
                DataSet ds = new DataSet();

                // DataSet에 데이터를 채운다 Fill 메서드는 da의 결과를 DataSet에 추가한다
                da.Fill(ds);

                // DataGrid의 ItemsSource를 DataSet의 첫 번째 테이블의 DefaultView로 설정한다
                dataGrid.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                // 예외가 발생하면 에러 메시지를 표시한다
                MessageBox.Show(ex.Message);
            }

            // 데이터베이스 연결을 닫는다
            conn.Close();
        }

        // 데이터 그리드의 선택 항목이 변경될 때 선택된 행의 정보를 다시 불러와서 채운다
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid; // sender를 DataGrid형태로 만든다
            DataRowView rowView = dg.SelectedItem as DataRowView; // 선택된 항목을 DataRowView로 만든다

            if (rowView == null)
            {
                // 선택된 항목이 없으면 종료한다
                return;
            }

            // 선택된 행의 각 열의 값을 인터페이스에 각각 설정한다
            txtEid.Text = rowView.Row[0].ToString();
            txtName.Text = rowView.Row[1].ToString();
            cbDept.Text = rowView.Row[2].ToString();
            cbPos.Text = rowView.Row[3].ToString();

            // 성별 라디오 버튼의 선택을 설정한다
            if (rowView.Row[4].ToString() == "남성")
            {
                rbMale.IsChecked = true;
                rbFemale.IsChecked = false;
            }
            else
            {
                rbMale.IsChecked = false;
                rbFemale.IsChecked = true;
            }

            // 입사일, 퇴사일, 연락처, 코멘트를 설정한다
            dpEnter.Text = rowView.Row[5].ToString();
            dpExit.Text = rowView.Row[6].ToString();
            txtContact.Text = rowView.Row[7].ToString();
            txtComment.Text = rowView.Row[8].ToString();
        }
    }
}
