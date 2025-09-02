using FireSharp.Config;
//firebase 를 사용하기 위한 네임스페이스
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Data;
using System.Windows.Forms; //우클릭 후 using 제거 밎 정렬 누르면 이 프로그램에서 사용하지 않는 using 정리해줌

namespace _022_FireBase
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable(); //데이터 그리드 뷰를 사용하기 위해 datatable 클래스를 이용한다.

        //Firebase를 사용하기 위해 주소와 비밀번호를 입력한다
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NreYnAXcCpLwYnQFBlIB4zhWaqVt63lt5jmjOCLH",
            BasePath = "https://vp2024-d817e-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client; //Firebase 클라이언트 객체 생성

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config); //firebase 클라이언트 초기화 //클라이언트를 앞에 있던 config 사용해서 만듬

            if(client != null) //성공적으로 firebase 연결되었는지 확인하기 위한 조건문
            {
                MessageBox.Show("Connection 성공!");
            }

            dt.Columns.Add("Id"); //데이터 테이블에 id,학번,이름,전화번호를 추가한다.
            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("전화번호");

            dataGridView1.DataSource = dt; //데이터그리드뷰에 표시될 데이터를 datatable 클래스의 dt로 지정한다

            
            export(); //그리드뷰에 표시시키는 함수를 호출한다

        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            // FireBase 에서 cnt 값을 가져온다
            FirebaseResponse resp = await client.GetAsync("Counter/");
            Counter c = resp.ResultAs<Counter>(); //Counter 클래스의 c에 firebase에서 불러온 결과값을 저장합니다.

            if(txtId.Text!= "") //만약 아이디칸에 텍스트가 입력되어 있다면 이미 입력되었다고 사용자에게 알려줍니다.
            {
                MessageBox.Show("Id는 auto increase 이므로 무시됩니다."); 
            }

            var data = new Data //data 클래스를 만들어 데이터들을 객체로 만든다
            {
                //Id = txtId.Text,
                Id = (c.cnt+1).ToString(), //아이디를 cnt에 저장되어있는 값에 1을 더한 값을 저장합니다.
                SId = txtSid.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,
            };

            SetResponse response = await client.SetAsync("Phonebook/" + data.Id, data); //ID값에 헤당하는 데이터들을  firebase에 phonebook 주소에 저장한다.
            //await로 저장이 완료될 때 까지 현재의 실행을 일시 정지한다 완료되면 그때 다음줄로 넘어간다.
            Data result = response.ResultAs<Data>(); //Data 클래스 타입으로 결과를 가져온다.

            MessageBox.Show("Data Inserted! Id = " + result.Id); //메세지박스로 저장된 데이터의 ID값을 출력시킨다.
            //SetAsync, GetAsync 등 외우기

            //Counter 를 업데이트
            var obj = new Counter //Counter의 값을 1 더하여 저장시켜줍니다.
            {
                cnt = c.cnt + 1 //Convert.ToInt32(result.Id)
            };
            SetResponse response1 = await client.SetAsync("Counter/", obj); //Counter의 경로에 cnt값을 덮어씌웁니다.

            dt.Rows.Clear(); //그리드뷰를 초기화합니다.
            export(); //export 함수를 실행시켜줍니다.

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtId.Text = ""; //텍스트박스들을 모두 빈칸으로 만든다
            //txtSid.Text = "";
            //txtName.Text = "";
            //txtPhone.Text = "";
            Clear();
        }

        private void Clear()
        {
            txtId.Text = ""; //텍스트박스들을 모두 빈칸으로 만든다
            txtSid.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private async void btnRetreve_Click(object sender, EventArgs e) //값을 읽어오는거
        {
            if (txtId.Text == "") //ID 텍스트박스가 비어있는 상태라면 종료한다.
                return;

            FirebaseResponse r = await client.GetAsync("Phonebook/"+txtId.Text); //firebase에서 헤당하는 ID에 저장된 데이터를 불러온다
            //await로 불러올때까지 일시정지한다.

            
            Data d = r.ResultAs<Data>(); //data 객체로 불러온 값을 반환시킨다.

            if (d == null) //만약 불러온 값이 null 이라면
            {
                MessageBox.Show("Id =" + txtId.Text + "없음"); //데이터가 없다는 메세지를 출력시킨다.
                return;
            }

            txtId.Text = d.Id; //불러온 값들을 각각 텍스트박스에 입력시킨다.
            txtSid.Text = d.SId;
            txtName.Text = d.Name;
            txtPhone.Text = d.Phone;

            dt.Rows.Clear(); //그리드뷰를 초기화시킨다
            export(); //export 함수를 실행한다.

            MessageBox.Show("Data Retrieved successfully!"); //불러오는걸 성공했다는 메세지를 출력시킨다.
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = new Data //수정할 데이터를 데이터 객체로 만든다.
            {
                Id = txtId.Text,
                Name= txtName.Text,
                Phone = txtPhone.Text,
                SId = txtSid.Text
            };
            FirebaseResponse r = await client.UpdateAsync("Phonebook/"+txtId.Text, data); //firebase 에서 헤당하는 ID에 대한 데이터를 업데이트한다.

            Data d = r.ResultAs<Data>(); //데이터형태로 불러온다.


            dt.Rows.Clear(); //위와 동일하다
            export();

            MessageBox.Show("Data Updated Successfully! Id = " + d.Id); //ID값과 성공적으로 업데이트하였다는 메세지를 출력한다.

            
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse r = await client.DeleteAsync("Phonebook/" + txtId.Text);
            //firebase의 헤당하는 id에 대한 데이터를 삭제한다
            dt.Rows.Clear(); //차트를 클리어하고 export 함수를 호출시켜준다
            export();

            MessageBox.Show("Deleted! : id ==" + txtId.Text); //id의 데이터를 삭제하였다는 메세지를 출력한다.
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("저장된 모든 데이터가 삭제됩니다. 계속하시겠습니까?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.No)
                return;

            FirebaseResponse r = await client.DeleteAsync("Phonebook"); //firebase의 phonebook 경로의 정보를 전부 삭제한다

            var obj = new Counter
            {
                cnt = 0
            };

            SetResponse resp = await client.SetAsync("Counter/",obj);
            
            dt.Rows.Clear();//차트를 클리어하고 export 함수를 호출시켜준다
            export();
            Clear();

            MessageBox.Show("All Data at /Phonebook node deleted! "); // 전부 삭제하였다는 메세지를 출력한다
        }

        private void btnViewall_Click(object sender, EventArgs e)
        {
            //// Counter 읽어오기 테스트
            //FirebaseResponse r = await client.GetAsync("Counter/");
            //Counter c = r.ResultAs<Counter>();
            //MessageBox.Show("cnt =" + c.cnt);
            dt.Rows.Clear();//차트를 클리어하고 export 함수를 호출시켜준다
            export();
        }

        private async void export()
        {
            int i = 0;
            FirebaseResponse r = await client.GetAsync("Counter/"); //getasync로 counter 에서 값을 r로 불러온다
            Counter obj = r.ResultAs<Counter>(); //Counter함수로 obj에 값을 저장한다
            int cnt = obj.cnt; //cnt 값을 따로 저장한다.

            while (i != cnt) //i가 cnt 값과 같아지기 전까지
            {
                i++; //i를 더하며
                FirebaseResponse resp = await client.GetAsync("Phonebook/"+i); //resp에 Phonebook의 i값에 헤당하는 값을 불러온다
                Data d = resp.ResultAs<Data>(); //데이터객체의 d에 값을 저장한다.

                if(d!= null) //만약 d 값이 비어있지 않다면
                {
                    DataRow row = dt.NewRow(); //데이터의 행의 row에 데이터테이블로 새로운 행을 추가한다
                    row["Id"] = d.Id; //행의 항목별로 값들을 추가해 준다
                    row["학번"] = d.SId;
                    row["이름"] = d.Name;
                    row["전화번호"] = d.Phone;
                    dt.Rows.Add(row); //행에 추가한다
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //그리드뷰의 셀을 클릭하였을 시에는
            DataGridView dgv = (DataGridView)sender; //dgv에 이벤트를 발생시킨 객체를 가져옵니다.
            if(e.RowIndex < 0)  //e. 의 값에 따라 행의 숫자가 달라집니다.
            {
                return;
            }
            txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSid.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString(); //각 행을 클릭시의 값을 텍스트박스에 표시합니다.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//시험문제에서 많이 나옴 이거
//빈칸 뚫어놓고 채우는거 나옴

//CRUD 의미 문제나올수도있음 외우기
//Create/Read/Update/Delete