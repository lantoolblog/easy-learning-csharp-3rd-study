# 13 도서 관리 프로그램

> 11/29... 😅 내일 오전까진 끝내야할 텐데... 😂
>
> 이번장은 그냥 거의 따라하면 되긴 하는데... 집중이 잘 안된다..😆



## 진행

✅ 한번 읽어보기





## 의견

* 역시 Windows Forms 개발이 만만치 않다. 그래도 결과물은 그럴듯하다 👍



## Ai와의 대화

# > label5~8의 갱신을 일단은 메서드로 분리해서 form 내에서는 대여/반납 할때, 그 메서드를 호출하도록 바꾸긴 했지만, 다른 Form2,3에서 도서나 사용자를 추가 제거할 때는 이벤트로 써야할 것 같아 어떻게해야하니?

`Form1`에서 다른 폼(`Form2`, `Form3`)이 데이터를 변경했을 때 `Form1`의 라벨을 갱신하려면, **이벤트**를 사용하는 것이 가장 깔끔합니다.

## 방법 1: 커스텀 이벤트 사용 (추천)

### 1. `DataManager`에 이벤트 추가

```csharp
// DataManager.cs
internal class DataManager
{
    public static List<Book> Books = [];
    public static List<User> Users = [];
    
    // 데이터 변경 이벤트
    public static event EventHandler? DataChanged;

    static DataManager()
    {
        Load();
    }

    public static void Save()
    {
        // ... 저장 코드 ...
        
        // 저장 후 이벤트 발생
        DataChanged?.Invoke(null, EventArgs.Empty);
    }
}
```

### 2. `Form1`에서 이벤트 구독

```csharp
public Form1()
{
    InitializeComponent();
    Text = "도서관 관리";

    // 데이터 변경 이벤트 구독
    DataManager.DataChanged += (sender, e) => UpdateStatusLabels();

    UpdateStatusLabels();
    // ... 나머지 초기화 ...
}
```

### 3. `Form2`, `Form3`에서는 그냥 저장만 호출

```csharp
// Form2, Form3에서
DataManager.Save(); // 이것만으로 자동으로 Form1의 라벨 갱신됨
```

---

## 방법 2: ShowDialog 후 직접 갱신 (현재 방식 개선)

```csharp
private void ToolStripMenuItem1_Click(object sender, EventArgs e)
{
    new Form2().ShowDialog();
    dataGridView1.DataSource = null;
    dataGridView1.DataSource = DataManager.Books;
    UpdateStatusLabels(); // 추가
}

private void ToolStripMenuItem2_Click(object sender, EventArgs e)
{
    new Form3().ShowDialog();
    dataGridView2.DataSource = null;
    dataGridView2.DataSource = DataManager.Users;
    UpdateStatusLabels(); // 추가
}
```

---

## 비교

| 방법                        | 장점                   | 단점                |
| --------------------------- | ---------------------- | ------------------- |
| **이벤트 방식**             | 자동 갱신, 확장성 좋음 | 초기 설정 필요      |
| **ShowDialog 후 직접 호출** | 간단함                 | 매번 수동 호출 필요 |

**추천: 방법 1 (이벤트 방식)**  
- 한 번만 설정하면 어디서든 `DataManager.Save()` 호출 시 자동으로 `Form1` 갱신됩니다.
- 코드가 더 깔끔하고, 나중에 기능 추가 시 유지보수가 쉽습니다.





## 정오표

* 557쪽 110번 코드라인은 불필요한 것 같다.





## 사용 아이콘

💡⬜✅✔✨👍😅