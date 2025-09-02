using System;
using System.Collections.Generic; 
using System.Diagnostics; 
using System.Linq; 
using System.Media; 
using System.Text;
using System.Threading.Tasks; 
using System.Windows; 
using System.Windows.Controls; 
using System.Windows.Data; 
using System.Windows.Documents; 
using System.Windows.Input; 
using System.Windows.Media; 
using System.Windows.Media.Imaging; 
using System.Windows.Shapes; 
using System.Windows.Threading; 

namespace _034_SnakeBite
{

    public partial class Game : Window
    {
        // 게임에 사용할 멤버 변수들 선언
        private Random r = new Random(); // 랜덤 값을 생성하기 위해 사용
        private Ellipse[] snakes; // 뱀의 몸체를 표현할 엘립스 배열
        private Ellipse egg; // 알을 표현할 엘립스
        private int unit = 10; // 위치를 10 단위로 설정
        private int visibleCount = 5; // 현재 화면에 보이는 뱀의 길이
        private DispatcherTimer t = new DispatcherTimer(); // 타이머를 사용
        private Stopwatch sw = new Stopwatch(); // 경과 시간을 측정하기 위해 사용
        private string move = ""; // 뱀의 이동 방향을 저장
        private int eaten = 0; // 먹은 알의 개수
        private SoundPlayer myPlayer; // 소리 재생을 위한 플레이어

        // 생성자
        public Game()
        {
            InitializeComponent();
            InitSnake(); // 뱀을 초기화
            InitEgg(); // 알을 초기화
            t.Interval = new TimeSpan(0, 0, 0, 0, 100); // 타이머 간격을 0.1초로 설정
            t.Tick += T_Tick; // 타이머 틱 설정
            myPlayer = new SoundPlayer(); // SoundPlayer 객체
            myPlayer.SoundLocation = "../../Sounds/Windows Notify.wav"; // 소리 파일 위치 설정
        }

        // 타이머 틱 이벤트
        private void T_Tick(object sender, EventArgs e)
        {
            // 뱀의 몸체를 이동
            for (int i = visibleCount; i > 0; i--)
                snakes[i].Tag = (Point)snakes[i - 1].Tag;

            // 뱀 머리 좌표 가져오기
            Point q = (Point)snakes[0].Tag;

            // 이동 방향에 따라 뱀 머리 위치를 업데이트
            if (move == "U")
                snakes[0].Tag = new Point(q.X, q.Y - unit);
            else if (move == "D")
                snakes[0].Tag = new Point(q.X, q.Y + unit);
            else if (move == "L")
                snakes[0].Tag = new Point(q.X - unit, q.Y);
            else if (move == "R")
                snakes[0].Tag = new Point(q.X + unit, q.Y);

            DrawSnakes(); // 뱀을 화면에 그리기
            Swatch(); // 경과 시간 업데이트
            EatEgg(); // 알을 먹었는지 확인
        }

        // 알을 먹었는지 확인하는 메서드
        private void EatEgg()
        {
            // 뱀 머리와 알의 위치 가져오기
            Point pS = (Point)snakes[0].Tag;
            Point pE = (Point)egg.Tag;

            // 뱀 머리가 알과 같은 위치에 있는지 확인
            if (pS.X == pE.X && pS.Y == pE.Y)
            {
                myPlayer.Play(); // 소리 재생
                egg.Visibility = Visibility.Hidden; // 알 숨기기
                visibleCount++; // 뱀의 길이 증가
                snakes[visibleCount - 1].Visibility = Visibility.Visible; // 새 뱀 부분을 보이게 설정
                score.Text = "Eggs = " + ++eaten; // 점수 업데이트

                // 뱀의 길이가 10이 되면 게임 종료
                if (visibleCount == 10)
                {
                    t.Stop(); // 타이머 중지
                    sw.Stop(); // 스톱워치 중지
                    DrawSnakes(); // 뱀 그리기
                    TimeSpan ts = sw.Elapsed; // 경과 시간 가져오기
                    string s = String.Format("Time = {0:00}:{1:00}.{2:00}",
                        ts.Minutes, ts.Seconds, ts.Milliseconds / 10); // 경과 시간 형식 지정
                    MessageBox.Show("Success!! \n" + s + " sec"); // 성공 메시지 표시
                    this.Close(); // 창 닫기
                }

                // 새로운 알 생성
                int x = r.Next(1, 48); // 랜덤 x 좌표
                int y = r.Next(1, 38); // 랜덤 y 좌표
                egg.Tag = new Point(x * unit, y * unit); // 알 위치 설정
                egg.Visibility = Visibility.Visible; // 알 보이기
                Canvas.SetLeft(egg, x * unit); // 알의 Canvas.Left 속성 설정
                Canvas.SetTop(egg, y * unit); // 알의 Canvas.Top 속성 설정
            }
        }

        // 경과 시간을 업데이트하는 메서드
        private void Swatch()
        {
            TimeSpan ts = sw.Elapsed; // 경과 시간 가져오기
            time.Text = String.Format("Time = {0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10); // 경과 시간 형식 지정
        }

        // 뱀을 화면에 그리는 메서드
        private void DrawSnakes()
        {
            for (int i = 0; i < visibleCount; i++)
            {
                Point p = (Point)snakes[i].Tag; // 뱀의 각 부분 위치 가져오기
                Canvas.SetLeft(snakes[i], p.X); // 뱀의 Canvas.Left 속성 설정
                Canvas.SetTop(snakes[i], p.Y); // 뱀의 Canvas.Top 속성 설정
            }
        }

        // 알을 초기화하는 메서드
        private void InitEgg()
        {
            egg = new Ellipse(); // 새 엘립스 객체 생성
            egg.Width = unit; // 알의 너비 설정
            egg.Height = unit; // 알의 높이 설정
            egg.Tag = new Point(r.Next(1, 480 / unit) * unit,
                r.Next(1, 380 / unit) * unit); // 알의 랜덤 위치 설정
            egg.Stroke = Brushes.Black; // 알의 테두리 색상 설정
            egg.Fill = Brushes.Red; // 알의 채우기 색상 설정

            Point p = (Point)egg.Tag; // 알의 위치 가져오기
            field.Children.Add(egg); // 알을 필드에 추가
            Canvas.SetLeft(egg, p.X); // 알의 Canvas.Left 속성 설정
            Canvas.SetTop(egg, p.Y); // 알의 Canvas.Top 속성 설정
        }

        // 뱀을 초기화하는 메서드
        private void InitSnake()
        {
            snakes = new Ellipse[30]; // 뱀의 최대 길이를 30으로 설정

            int x = r.Next(1, 48); // 랜덤 x 좌표
            int y = r.Next(1, 38); // 랜덤 y 좌표

            for (int i = 0; i < 30; i++)
            {
                snakes[i] = new Ellipse(); // 새 엘립스 객체 생성
                snakes[i].Width = unit; // 뱀의 너비 설정
                snakes[i].Height = unit; // 뱀의 높이 설정
                snakes[i].Stroke = Brushes.Black; // 뱀의 테두리 색상 설정
                if (i % 5 == 0) // 뱀의 부분마다 색상을 다르게 설정
                    snakes[i].Fill = Brushes.Green;
                else
                    snakes[i].Fill = Brushes.Gold;

                snakes[0].Fill = Brushes.Chocolate; // 뱀의 머리 색상 설정

                snakes[i].Tag = new Point(x * unit, (y + i) * unit); // 뱀의 위치 설정
                field.Children.Add(snakes[i]); // 뱀을 필드에 추가
                Canvas.SetLeft(snakes[i], x * unit); // 뱀의 Canvas.Left 속성 설정
                Canvas.SetTop(snakes[i], (y + i) * unit); // 뱀의 Canvas.Top 속성 설정
            }

            for (int i = visibleCount; i < 30; i++)
                snakes[i].Visibility = Visibility.Hidden; // 현재 보이지 않는 뱀의 부분은 숨김
        }

        // 키 입력 이벤트 핸들러
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            t.Start(); // 타이머 시작
            sw.Start(); // 스톱워치 시작
            if (e.Key == Key.Left) // 왼쪽 화살표 키
                move = "L";
            else if (e.Key == Key.Right) // 오른쪽 화살표 키
                move = "R";
            else if (e.Key == Key.Up) // 위쪽 화살표 키
                move = "U";
            else if (e.Key == Key.Down) // 아래쪽 화살표 키
                move = "D";
            else if (e.Key == Key.Escape) // ESC 키
            {
                move = ""; // 이동 멈춤
                t.Stop(); // 타이머 중지
            }
        }
    }
}
