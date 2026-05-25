# study-windows-programming — Windows 프로그래밍 학습 아카이브

> Windows 데스크톱 응용 프로그래밍 한 학기 학습의 결과물입니다. 같은 BMI 문제를 **C / C++ / C# Console / C# WinForms** 4가지로 풀어보며 시작해, WinForms 기본 컴포넌트 → 차트·시계 → 외부 DB(Firebase, MySQL) 연동 → WPF 전환 → 게임까지 점진적으로 확장한 34 챕터의 기록입니다.

---

## 📚 학습 컨텍스트

- **시기:** 2024년 *1*학기 
- **과목:** Windows 프로그래밍 / 비주얼 프로그래밍 
- **사용 언어 / 프레임워크:**
  - C, C++ (Console)
  - C# (Console → **WinForms** → **WPF**)
  - 외부 연동: Firebase Realtime DB (FireSharp), MySQL (MySql.Data)
- **개발 도구:** Visual Studio 2022, .NET Framework
- **학습 목표:**
  - 같은 문제를 여러 언어/플랫폼으로 풀어 **언어·플랫폼 간 차이를 직접 체감**
  - WinForms로 GUI 기본기를 다진 후, **WPF로 자연스럽게 마이그레이션** 하며 차세대 GUI 기술 학습
  - 클라이언트-DB 연동(NoSQL/RDBMS) 까지 한 학기에 모두 경험

---

## 🧭 디렉토리 구조 — 학습 흐름 (7 단계 · 34 챕터)

### Phase 1 · 같은 문제, 다른 언어 (001 ~ 004)
| 챕터 | 폴더 | 내용 |
|---|---|---|
| 001 | `001_bmiC/` | BMI 계산기 — **C** (`printf`/`scanf_s`) |
| 002 | `002_bmiCPP/` | BMI 계산기 — **C++** (`cin`/`cout`) |
| 003 | `003_bmiCS/` | BMI 계산기 — **C# Console** |
| 004 | `004_bmiForms/` | BMI 계산기 — **C# WinForms** (GUI 전환의 첫 마일스톤. 결과에 따라 PictureBox 색이 바뀌도록 시각화) |

### Phase 2 · WinForms 컴포넌트 기본기 (005 ~ 012)
| 챕터 | 폴더 | 학습 내용 |
|---|---|---|
| 005 | `005_login/` | 로그인 폼 |
| 006 | `006_BasicCompo/` | 기본 컴포넌트 종합 |
| 007 | `007_MessageBoxes/` | MessageBox 변형 |
| 008 | `008_Labels/` | Label 컨트롤 |
| 009 | `009_CheckBox/` | 체크박스 |
| 010 | `010_RadioBtn/` | 라디오버튼 |
| 011 | `011_ScoreCalq/` | 성적 계산기 — 컴포넌트 종합 응용 |
| 012 | `012_Combo/` | 콤보박스 |

### Phase 3 · 프로그래밍 기초 응용 (013 ~ 016)
| 챕터 | 폴더 | 학습 내용 |
|---|---|---|
| 013 | `013_Array/` | 배열 |
| 014 | `014_loop/` | 반복문 |
| 015 | `015_Random/` | 난수 생성 |
| 016 | `016_Test/` | 종합 실습 |

### Phase 4 · 시각화 + 시간 처리 (017 ~ 021)
| 챕터 | 폴더 | 학습 내용 |
|---|---|---|
| 017 | `017_Chart/` | Chart 컨트롤로 데이터 시각화 |
| 018 | `018_TwoChart/` | 차트 2개를 동시에 비교 표시 |
| 019 | `019_Math/` | 수학 함수 활용 |
| 020 | `020_DClock/` | 디지털 시계 — `Timer` 활용 (1초 간격 갱신) |
| 021 | `021_AnalogClock/` | 아날로그 시계 — Graphics 직접 그리기 |

### Phase 5 · 외부 시스템 연동 + 다중 화면 (022 ~ 025)
| 챕터 | 폴더 | 학습 내용 |
|---|---|---|
| 022 | `022_FireBase/` | **Firebase Realtime DB 연동** (FireSharp 라이브러리) 
| 023 | `023_Property/` | 속성(Property) 다루기 |
| 024 | `024_TwoForms/` | 폼 간 화면 전환·데이터 전달 |
| 025 | `025_SensorMonitering/` | 센서 모니터링 시뮬레이션 (의료IT 응용 가능성 첫 발견) |

### Phase 6 · WPF 로 전환 (026 ~ 031)
WinForms 에서 다음 세대 GUI 인 **WPF**로 마이그레이션. 같은 컴포넌트를 WPF 방식으로 다시 학습.

| 챕터 | 폴더 | 학습 내용 |
|---|---|---|
| 026 | `026_WpfHello/` | **WPF 입문** — `MainWindow.xaml` + 코드비하인드 구조 |
| 027 | `027_Grid/` | Grid 레이아웃 |
| 028 | `028_StckPanel/` | StackPanel 레이아웃 |
| 029 | `029_WpfLogin/` | WPF 로그인 (005 와 비교 학습) |
| 030 | `030_CheckBox/` | WPF 체크박스 |
| 031 | `031_Button/` | WPF 버튼 |
| 031b | `031_wpfgae/` | WPF 계산기 앱 (사칙연산 + 메모리) |

### Phase 7 · WPF 종합 응용 (033 ~ 034)
| 챕터 | 폴더 | 학습 내용 |
|---|---|---|
| 033 | `033_Mysql/` | **MySQL 연동** — 직원 정보 시스템(EIS) CRUD. DatePicker, ComboBox, RadioButton, DataGrid 종합 |
| 034 | `034_SnakeBite/` | **스네이크 게임** — `Game` 클래스 분리, 별도 윈도우 생성, 키 입력 처리 |

> 📌 학습이 **콘솔 → WinForms → 외부 DB 연동 → WPF → 게임** 으로 추상화 수준이 한 단계씩 올라가며 진행됩니다. 한 학기 안에 C, C++, C#, WinForms, WPF, Firebase, MySQL을 모두 한 번씩 만져본 압축 학습입니다.

---

## 🔧 빌드 / 실행

각 챕터는 독립적인 Visual Studio 프로젝트입니다.

```bash
# Visual Studio 2022에서 챕터 폴더의 .sln 열기 → F5
# 또는 명령줄
dotnet build
dotnet run
```

**외부 의존성:**
- `022_FireBase/` — NuGet 패키지 `FireSharp` 필요
- `033_Mysql/` — NuGet 패키지 `MySql.Data` 필요 + 로컬 MySQL 서버 (`server=localhost`, `database=eis_db`) 필요

---

## 💡 학습 포인트 (코드에 남긴 흔적)

이 레포의 코드들은 **한국어 주석으로 매 줄의 의미와 의도를 본인이 직접 설명**해둔 점이 특징입니다. 예시 몇 가지:

### Phase 1 — "같은 문제, 다른 언어" 비교 학습

`001_bmiC/001_bmiC.cpp` (C):
```c
scanf_s("%lf", &w);
double bmi = w / ((h / 100) * (h / 100));
printf("bmi = %lf\n", bmi);
```

`004_bmiForms/Form1.cs` (WinForms, 같은 계산):
```csharp
double w = double.Parse(txtW.Text);            // textbox에 입력된 값을 double 형으로 변환
double h = double.Parse(txtH.Text)/100;         // 100으로 나누어서 저장 — bmi 계산 편하게
double bmi = w / (h * h);
lblBMI.Text = "BMI = " + bmi.ToString("#.##"); // 소수점 형식 지정하여 출력

if (bmi < 20) {
    lblres.Text = "판정 = " + "저체중";
    pictureBox1.BackColor = Color.Blue;          // PictureBox 색을 결과에 따라 시각화
}
```
같은 알고리즘을 콘솔에서 GUI로 옮기며, **"입력은 텍스트박스에서, 출력은 라벨과 색상으로"** 라는 GUI 사고를 익혀가는 과정이 코드에 그대로 드러납니다.

### Phase 5 — Firebase 연동의 학습 메모

`022_FireBase/Form1.cs`:
```csharp
//우클릭 후 using 제거 및 정렬 누르면 이 프로그램에서 사용하지 않는 using 정리해줌
DataTable dt = new DataTable();  // 데이터 그리드 뷰를 사용하기 위해 datatable 클래스를 이용한다.

IFirebaseClient client;          // Firebase 클라이언트 객체 생성

client = new FireSharp.FirebaseClient(config); // 클라이언트를 앞에 있던 config 사용해서 만듬

if (client != null) {            // 성공적으로 firebase 연결되었는지 확인하기 위한 조건문
    MessageBox.Show("Connection 성공!");
}
```
IDE 단축키(`using` 정리)부터 클라이언트 객체의 의미까지, 본인이 "이건 왜 이렇게 하는가" 를 코드 안에서 자문자답한 흔적이 남아 있습니다.

### Phase 7 — MySQL CRUD의 한글 설명형 변수

`033_Mysql/MainWindow.xaml.cs`:
```csharp
private string pos;        // 직급
private string dept;       // 부서
private string gender;     // 성별
private string dateEnter;  // 입사일
private string dateExit;   // 퇴사일

// 입사일과 퇴사일을 선택된 날짜로 설정, 선택되지 않은 경우 최대값으로 지정
if (dpExit.SelectedDate != null)
    dateExit = dpExit.SelectedDate.Value.Date.ToShortDateString();
else
    dateExit = DateTime.MaxValue.ToShortDateString();
```
변수마다 한글 설명을 달아두고, "선택 안 됐을 때는 MaxValue로" 같은 엣지 케이스 처리까지 본인 사고로 정리.

---

## ✍️ 회고

이 수업은 **"같은 일을 점점 더 추상화된 방법으로 다시 해본다"** 의 연속이었습니다.

- BMI 한 문제를 **4번 다시 풀면서** (C → C++ → C# Console → WinForms), 언어가 추상화되면서 *"내가 신경 안 써도 되는 것"* 이 무엇인지 직접 비교 체감했습니다.
- 로그인 폼을 WinForms(005)와 WPF(029) 로 **두 번 만들어보며**, GUI 패러다임이 *"코드로 화면을 그리는 방식(WinForms)"* 에서 *"XAML로 선언하는 방식(WPF)"* 으로 진화했음을 손으로 익혔습니다.
- Firebase(NoSQL, 022) 와 MySQL(RDBMS, 033) 을 한 학기에 둘 다 다뤄보며, **데이터를 저장하는 두 가지 방식** 의 차이가 자연스럽게 들어왔습니다.
- 마지막 챕터의 스네이크 게임(034)은 그동안 익힌 *컨트롤·이벤트·렌더링·다중 윈도우* 가 한 곳에 응축된 종합 과제였습니다.

특히 **`025_SensorMonitering`** 에서 데이터 시각화 + 실시간 갱신을 다루며, *"센서 데이터를 모니터링하는 화면"* 이라는 의료IT의 핵심 패턴을 처음 만져봤습니다. 이 경험이 이후 [`MedQueue`](https://github.com/MoriochoRadio/MedQueue) (병원 라이브 큐), [`ElderCaringApp`](https://github.com/MoriochoRadio/ElderCaringApp) (노인 케어 모니터링) 으로 자연스럽게 이어졌습니다.

---


---

## 🗂️ 다른 학습 레포

- [`study-algorithms`](https://github.com/MoriochoRadio/study-algorithms) — 알고리즘 패러다임 (C++ / C#)
- [`study-java`](https://github.com/MoriochoRadio/study-java) — Java 객체지향 + Swing GUI

---

*Author: [MoriochoRadio](https://github.com/MoriochoRadio) (KimTaeKyoung) · 의료IT공학 전공*
