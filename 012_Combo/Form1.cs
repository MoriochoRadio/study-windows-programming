using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_Combo
{
    public partial class Form1 : Form
    {

        TextBox[] titles; //교과목 Textbox 배열
        ComboBox[] crds; //학점 ComboBox배열
        ComboBox[] grds; //성적 배열

        public Form1() //생정자
        {
            InitializeComponent(); 
        }

        private double GetGrade(string text)
        {
            double grade = 0;

            if (text == "A+") grade = 4.5;
            else if (text == "A0") grade = 4.0;
            else if (text == "B+") grade = 3.5;
            else if (text == "B0") grade = 3.0;
            else if (text == "C+") grade = 2.5;
            else if (text == "C0") grade = 2.0;
            else if (text == "D+") grade = 1.5;
            else if (text == "D0") grade = 1.0;
            else grade = 0;
            return grade;
        }

        


        private void button1_Click(object sender, EventArgs e) //사용자가 버튼을 눌렀을때입니다.
        {
            double totalScore = 0; //학점과 성적을 총합한 계산을 저장하기 위한 double변수를 생성합니다.
            int totalCredits = 0; //학점의 총합을 계산한 값을 저장하기 위한 int 변수를 생성합니다. 

            for (int i = 0; i < crds.Length; i++) //학점 배열의 길이만큼 반복문을 시작합니다.
            {
                if (titles[i].Text != "") //만약 교과목이 비어있지 않다면 아래의 코드를 실행합니다.
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString()); //crd 변수에 각 교과목의 학점을 저장합니다.
                    totalCredits += crd; //totalCredits에 학점을 반복문을 통해 모두 더하도록 합니다.
                    totalScore += crd * GetGrade(grds[i].SelectedItem.ToString()); //GetGrade라는 함수에 선택된 성적을 보내준 후
                                                                                   //함수를 통해 성적에 맞는 값을 받은 후 학점에 곱합니다.
                                                                                   //그 뒤에는 totalScore변수에 반복문을 통해 모두 더합니다.
                }
            }
            txtGrade.Text = (totalScore / totalCredits).ToString("0.00"); //반복문을 빠져나온 후의 변수들을 이용해 최종 평균평점을 계산하여 표시합니다.
        }

        //Form1이 Load 될 때 ( 프로그램이 시작 될 때)
        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "일반수학";
            txt3.Text = "비주얼프로그래밍";
            txt4.Text = "전기전자공학";
            txt5.Text = "영어";
            txt6.Text = "설계및프로젝트";
            txt7.Text = "교양1";
            txt8.Text = "교양2";

            crds = new ComboBox[] {crd1 ,crd2 ,crd3 ,crd4 ,crd5 ,crd6, crd7, crd8 };
            grds = new ComboBox[] {grd1, grd2, grd3, grd4, grd5, grd6, grd7, grd8 };
            titles = new TextBox[] {txt1 ,txt2 ,txt3 ,txt4 ,txt5 ,txt6, txt7, txt8 };
            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<String> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };


            //학점 콤보박스 배열 crds의 각 요소에 대해 arrCredit의 각 요소를 Items 로 등록하고
            //최초에 3학점을 SelectedItem으로 지정
            foreach (var combo in crds) //crds배열에 있는 각각의 이름을 combo라고 지은 콤보박스에 대해서 (var는 다 통용되므로 var라고씀) 여기선 var말고 쓸려면 ComboBox라고 써야함
            {
                foreach(var i in arrCredit)
                {
                    combo.Items.Add(i);
                }
                combo.SelectedItem = 3;
            }

            //성적 콤보박스 배열 grds의 각 요소에 대해 lstgrade 리스트의 각 요소를  Items로 등록한다.
            foreach (var cb in grds) 
            {
                foreach( var gr in lstGrade)// var 대신 string 으로 써도됨
                {
                    cb.Items.Add(gr);
                }
            }


        }
    }
}
