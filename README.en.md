# study-windows-programming — Windows Programming Study Archive

🇰🇷 [한국어](README.md) · 🇬🇧 English

> The results of one semester studying Windows desktop application programming. A 34-chapter record that starts by solving the same BMI problem four ways — **C / C++ / C# Console / C# WinForms** — then expands step by step through core WinForms components → charts and clocks → external DB integration (Firebase, MySQL) → migration to WPF → a game.

---

## 📚 Study Context

- **Period:** Spring semester 2024
- **Course:** Windows Programming / Visual Programming
- **Languages / frameworks:**
  - C, C++ (Console)
  - C# (Console → **WinForms** → **WPF**)
  - External integrations: Firebase Realtime DB (FireSharp), MySQL (MySql.Data)
- **Tools:** Visual Studio 2022, .NET Framework
- **Learning goals:**
  - Solve the same problem in multiple languages/platforms to **feel the differences between them firsthand**
  - Build GUI fundamentals with WinForms, then **migrate naturally to WPF** to learn the next-generation GUI technology
  - Experience client–DB integration (NoSQL/RDBMS) all within a single semester

---

## 🧭 Directory Structure — Learning Flow (7 Phases · 34 Chapters)

### Phase 1 · Same Problem, Different Languages (001 – 004)
| Chapter | Folder | Content |
|---|---|---|
| 001 | `001_bmiC/` | BMI calculator — **C** (`printf`/`scanf_s`) |
| 002 | `002_bmiCPP/` | BMI calculator — **C++** (`cin`/`cout`) |
| 003 | `003_bmiCS/` | BMI calculator — **C# Console** |
| 004 | `004_bmiForms/` | BMI calculator — **C# WinForms** (first milestone of the move to GUI; visualizes the result by changing a PictureBox color) |

### Phase 2 · WinForms Component Fundamentals (005 – 012)
| Chapter | Folder | Topic |
|---|---|---|
| 005 | `005_login/` | Login form |
| 006 | `006_BasicCompo/` | Basic components overview |
| 007 | `007_MessageBoxes/` | MessageBox variations |
| 008 | `008_Labels/` | Label control |
| 009 | `009_CheckBox/` | Checkboxes |
| 010 | `010_RadioBtn/` | Radio buttons |
| 011 | `011_ScoreCalq/` | Grade calculator — applied combination of components |
| 012 | `012_Combo/` | Combo box |

### Phase 3 · Applying Programming Basics (013 – 016)
| Chapter | Folder | Topic |
|---|---|---|
| 013 | `013_Array/` | Arrays |
| 014 | `014_loop/` | Loops |
| 015 | `015_Random/` | Random number generation |
| 016 | `016_Test/` | Comprehensive practice |

### Phase 4 · Visualization + Time Handling (017 – 021)
| Chapter | Folder | Topic |
|---|---|---|
| 017 | `017_Chart/` | Data visualization with the Chart control |
| 018 | `018_TwoChart/` | Displaying two charts side by side for comparison |
| 019 | `019_Math/` | Using math functions |
| 020 | `020_DClock/` | Digital clock — using `Timer` (updates every second) |
| 021 | `021_AnalogClock/` | Analog clock — drawing directly with Graphics |

### Phase 5 · External System Integration + Multiple Screens (022 – 025)
| Chapter | Folder | Topic |
|---|---|---|
| 022 | `022_FireBase/` | **Firebase Realtime DB integration** (FireSharp library) 
| 023 | `023_Property/` | Working with properties |
| 024 | `024_TwoForms/` | Switching between forms and passing data |
| 025 | `025_SensorMonitering/` | Sensor monitoring simulation (first glimpse of medical IT applications) |

### Phase 6 · Migrating to WPF (026 – 031)
Migrating from WinForms to the next-generation GUI, **WPF**. Relearning the same components the WPF way.

| Chapter | Folder | Topic |
|---|---|---|
| 026 | `026_WpfHello/` | **Intro to WPF** — `MainWindow.xaml` + code-behind structure |
| 027 | `027_Grid/` | Grid layout |
| 028 | `028_StckPanel/` | StackPanel layout |
| 029 | `029_WpfLogin/` | WPF login (studied in comparison with 005) |
| 030 | `030_CheckBox/` | WPF checkboxes |
| 031 | `031_Button/` | WPF buttons |
| 031b | `031_wpfgae/` | WPF calculator app (arithmetic + memory) |

### Phase 7 · WPF Capstone Applications (033 – 034)
| Chapter | Folder | Topic |
|---|---|---|
| 033 | `033_Mysql/` | **MySQL integration** — employee information system (EIS) CRUD. DatePicker, ComboBox, RadioButton, DataGrid combined |
| 034 | `034_SnakeBite/` | **Snake game** — separate `Game` class, spawning a separate window, keyboard input handling |

> 📌 The learning progresses through **console → WinForms → external DB integration → WPF → a game**, raising the level of abstraction one step at a time. A compressed course that touches C, C++, C#, WinForms, WPF, Firebase, and MySQL all in one semester.

---

## 🔧 Build / Run

Each chapter is an independent Visual Studio project.

```bash
# Open the chapter folder's .sln in Visual Studio 2022 → F5
# Or from the command line
dotnet build
dotnet run
```

**External dependencies:**
- `022_FireBase/` — requires the NuGet package `FireSharp`
- `033_Mysql/` — requires the NuGet package `MySql.Data` plus a local MySQL server (`server=localhost`, `database=eis_db`)

---

## 💡 Learning Highlights (Traces Left in the Code)

What distinguishes the code in this repo is that **the meaning and intent of every line is explained in my own words through Korean comments**. A few examples:

### Phase 1 — "Same problem, different languages" comparative learning

`001_bmiC/001_bmiC.cpp` (C):
```c
scanf_s("%lf", &w);
double bmi = w / ((h / 100) * (h / 100));
printf("bmi = %lf\n", bmi);
```

`004_bmiForms/Form1.cs` (WinForms, same computation):
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
Moving the same algorithm from console to GUI, the code plainly shows the process of internalizing the GUI mindset of **"input comes from text boxes; output goes to labels and colors."**

### Phase 5 — Study notes from the Firebase integration

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
From an IDE shortcut (organizing `using` directives) to the meaning of the client object, the traces of asking and answering my own "why do we do it this way?" remain in the code.

### Phase 7 — MySQL CRUD with Korean-annotated variables

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
Each variable carries a Korean note, and even edge cases like "use MaxValue when nothing is selected" are reasoned through in my own words.

---

## ✍️ Retrospective

This course was a continuous exercise in **"doing the same thing again with progressively more abstract methods."**

- Solving the single BMI problem **four times over** (C → C++ → C# Console → WinForms), I directly compared and felt what *"the things I no longer have to worry about"* are as the language becomes more abstract.
- Building the login form **twice**, in WinForms (005) and WPF (029), I learned hands-on how the GUI paradigm evolved from *"drawing the screen in code (WinForms)"* to *"declaring it in XAML (WPF)."*
- Handling both Firebase (NoSQL, 022) and MySQL (RDBMS, 033) in one semester, the difference between **the two ways of storing data** sank in naturally.
- The final chapter's Snake game (034) was a capstone assignment condensing everything learned so far — *controls, events, rendering, and multiple windows* — into one place.

In particular, working with data visualization + real-time updates in **`025_SensorMonitering`**, I touched for the first time the core medical-IT pattern of *"a screen that monitors sensor data."* That experience led naturally to [`MedQueue`](https://github.com/MoriochoRadio/MedQueue) (hospital live queue) and [`ElderCaringApp`](https://github.com/MoriochoRadio/ElderCaringApp) (elder care monitoring).

---

## 🗂️ Other Study Repositories

- [`study-algorithms`](https://github.com/MoriochoRadio/study-algorithms) — algorithm paradigms (C++ / C#)
- [`study-java`](https://github.com/MoriochoRadio/study-java) — Java OOP + Swing GUI

---

*Author: [MoriochoRadio](https://github.com/MoriochoRadio) (KimTaeKyoung) · Medical IT Engineering major*
