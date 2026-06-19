# 14 인공지능 챗봇 프로그램

> 오늘 ..12/1 .. 11/30일까지 끝냈으면 좋았는데, 그러지 못했다. 😅
>
> 약간 복잡하게  Windows Forms 그리는거에 망설인듯..😅😅😅
>
> 이번장은 OpenAI를 활용한 챗봇 만드는 장인데... OpenAI 구독중이 아니여서, Gemini를 적용해서 구현해봐야겠다. 👍
>
> 오늘 끝낼 수 있을까..😂



## 진행

✅ 한번 읽어보기





## 의견

* 어제까진 다 보았어야하는데... 놀고 먹어서 ㅋ😅
* 그래도 책은 재미있었다. C#에 대해 좀 더 잘 이해할 수 있게 되었다. 👍



## Ai와의 대화

# > C# 최상위 문 관련 아래 주석이 적절하니?

```
// 💡 최상위 구문에서 클래스는 문서 하단에 적어야한다.
```

네, **아주 적절하고 정확한 주석**입니다! 👍

작성하신 주석(`// 💡 최상위 구문에서 클래스는 문서 하단에 적어야한다.`)은 C#의 **최상위 문(Top-level statements)** 규칙을 아주 잘 설명하고 있습니다.

그 이유는 다음과 같습니다.

1. **C# 컴파일러 규칙**: 최상위 문을 사용할 때, 실행 가능한 로직(변수 선언, 메서드 호출 등)은 반드시 **클래스나 네임스페이스 선언보다 먼저** 나와야 합니다.
2. **에러 방지**: 만약 `class Book` 정의를 `Console.WriteLine(output);`보다 위로 올리면, 컴파일러는 `CS8803: Top-level statements must precede namespace and type declarations.` 에러를 발생시킵니다.

따라서, 나중에 코드를 보거나 다른 사람이 코드를 볼 때 "왜 클래스가 맨 아래에 있지?"라고 의문을 갖지 않도록 도와주는 좋은 가이드입니다.

참고로, 유일한 예외는 맨 윗줄의 `using` 선언부입니다. 순서는 다음과 같아야 합니다.

1. `using` 선언
2. **최상위 문 (실행 코드)** 👈 *여기에 주석이 위치한 맥락*
3. 클래스/네임스페이스 선언 (맨 하단)



# > JSON에서 데이터 가져올 때... int로 받을 땐 int32로 받니?

네, 맞습니다! 정확하게 보셨어요.

C#에서 **`int`**라는 키워드는 **`System.Int32`** (32비트 부호 있는 정수)의 **별칭(Alias)**입니다. 두 표현은 완전히 같은 타입을 의미합니다.

따라서 `System.Text.Json`을 사용하여 `JsonElement`에서 표준 `int` 타입으로 값을 꺼낼 때는 **`.GetInt32()`**를 사용하는 것이 정석입니다.

### 조금 더 자세히 설명드리자면:

1. **C#의 `int` == `Int32`**:
   - `public int Price { get; set; }`라고 선언하셨으므로, 이 변수는 32비트 정수(`-2,147,483,648` ~ `2,147,483,647`)를 담습니다.
2. **`GetInt32()`의 역할**:
   - JSON에 있는 숫자(예: `20000`)가 실제로 32비트 정수 범위 안에 들어오는지 확인하고, 안전하게 C#의 `int` 값으로 변환해 줍니다.

### 만약 다른 크기의 정수라면?

`System.Text.Json`은 데이터 크기에 맞춰서 명확한 메서드를 제공합니다.

- **`int`** (`System.Int32`) -> `.GetInt32()`
- **`long`** (`System.Int64`) -> `.GetInt64()` (숫자가 아주 클 때)
- **`short`** (`System.Int16`) -> `.GetInt16()`
- **`byte`** (`System.Byte`) -> `.GetByte()`

작성하신 코드의 `Price`는 `int`형이므로 `.GetInt32()`가 가장 적절한 선택입니다. 👍



# > OpenAI에 맞춰진 Message 모델을 컨버팅해서 사용하려니... 괜히 복잡하게 느껴지는데... message 클래스의 구조를 바꿔도 되니까.. 더 단순하게 바꿀 수 있을까?

네, `Message` 클래스의 구조를 Gemini API 스펙에 맞춰 변경하고, `GetAiResponseAsync` 메서드를 훨씬 단순하게 수정했습니다.

**주요 변경 사항:**

1.  **`Message` 클래스 구조 변경:**
    *   `Role`, `Content` 속성 대신 Gemini API가 사용하는 `role`, `parts` 속성으로 변경했습니다.
    *   `Part` 클래스를 추가하여 중첩 구조를 표현했습니다.
    *   생성자에서 텍스트를 받으면 자동으로 `parts` 배열로 변환하도록 했습니다.

2.  **`GetAiResponseAsync` 단순화:**
    *   복잡했던 `Select` 투영 로직을 제거했습니다.
    *   `_messages` 리스트를 그대로 `contents` 필드에 할당하여 직렬화하도록 수정했습니다.
    *   응답 저장 시 역할을 `"assistant"` 대신 `"model"`로 저장하여 일관성을 유지했습니다.

이제 코드가 훨씬 직관적이고 Gemini API 구조와 일치하게 되었습니다. 실행해 보시고 잘 동작하는지 확인해 주세요

변경했습니다.

# > C#에서 public 필드는 첫글짜가 대문자로 시작인데...   대문자로 바꾸면  이게 JSON 데이터내에서도 대문자가 되서 오류가 발생하겠지?

네, 맞습니다. C#의 `JsonSerializer`는 기본적으로 속성 이름을 그대로 JSON 키로 사용합니다. 따라서 C# 속성을 대문자(`Role`, `Parts`)로 바꾸면 JSON도 대문자 키(`"Role": ...`)로 직렬화되어, 소문자 키(`"role"`, `"parts"`)를 기대하는 Gemini API에서 오류가 발생할 수 있습니다.

이를 해결하면서 C# 네이밍 컨벤션(PascalCase)을 지키려면, `[JsonPropertyName]` 특성을 사용하거나 `JsonSerializerOptions`를 설정하면 됩니다.

가장 간단하고 명시적인 방법인 `[JsonPropertyName]` 특성을 사용하여 코드를 수정해 드리겠습니다.

```csharp
// ...existing code...
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization; // 이 네임스페이스 추가 필요

namespace ChatBot;

public partial class Form1 : Form
{
// ...existing code...
    // 인공지능 메시지를 나타내는 클래스
    private sealed class Message(string role, string text)
    {
        [JsonPropertyName("role")]
        public string Role { get; set; } = role;

        [JsonPropertyName("parts")]
        public Part[] Parts { get; set; } = [new Part { Text = text }];
    }

    private sealed class Part
    {
        [JsonPropertyName("text")]
        public required string Text { get; set; }
    }

    // 메시지를 저장하는 리스트
// ...existing code...
```

이렇게 하면 C# 코드에서는 `Role`, `Parts`, `Text`로 대문자를 사용하고, JSON으로 변환될 때는 자동으로 `"role"`, `"parts"`, `"text"`로 변환됩니다.

# > 이 부분은 contents가 들어가는 익명 타입인거니?

네, 맞습니다!

```csharp
var requestBody = new
{
    contents = _messages
};
```

이 코드는 **익명 타입(Anonymous Type)**을 생성하는 구문입니다.
컴파일러는 내부적으로 `contents`라는 속성을 가진 이름 없는 클래스를 만들고, 그 속성에 `_messages` 리스트를 할당합니다.

`JsonSerializer.Serialize(requestBody)`를 호출하면, 이 익명 타입의 속성 이름인 `contents`가 JSON의 키가 되어 다음과 같은 JSON 문자열이 생성됩니다.

```json
{
  "contents": [
    { "role": "user", "parts": [{ "text": "..." }] },
    ...
  ]
}
```

Gemini API가 최상위 객체에 `contents`라는 키를 요구하기 때문에, 이렇게 익명 타입을 사용하여 간단하게 JSON 구조를 맞춘 것입니다.



# > 최근 대화 10개만 전달하도록 수정하려면 이부분에서 잘라내면 되는거지?

네, 맞습니다! `_messages` 리스트 전체를 보내는 대신, 최근 10개만 잘라서 보내면 됩니다.

`Skip`과 `Take`를 사용하거나, `TakeLast` (LINQ)를 사용하여 간단하게 처리할 수 있습니다.

```csharp
// Gemini API 요청 본문 구성
var requestBody = new
{
    // 전체 메시지 중 최근 10개만 선택
    contents = _messages.TakeLast(10).ToList()
};
```

이렇게 수정하면 `_messages`에 아무리 많은 대화가 쌓여도, API 요청에는 항상 마지막 10개의 대화만 포함되어 토큰 사용량을 절약할 수 있습니다.



# > 텍스트 박스에서 Enter를 입력했을 때.. 바로 전송 (버튼  클릭) 되게 하려면 어떻게 하니?

텍스트 박스(`textBox1`)의 `KeyDown` 이벤트를 사용하여 Enter 키 입력을 감지하고, `Button1_Click` 메서드를 호출하거나 `button1.PerformClick()`을 실행하면 됩니다.

`Form1` 생성자에서 이벤트를 연결하는 코드를 추가해 보세요.

```csharp
// ...existing code...
    public Form1()
    {
        InitializeComponent();
        richTextBox1.Enabled = false;

        button1.Click += Button1_Click;
        // 텍스트 박스에서 키 입력 이벤트 연결
        textBox1.KeyDown += TextBox1_KeyDown;
    }

    private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
    {
        // Enter 키가 눌렸고, 텍스트가 비어있지 않다면 전송
        if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text))
        {
            // 띵 소리 방지 (선택 사항)
            e.SuppressKeyPress = true; 
            // 전송 버튼 클릭 효과
            button1.PerformClick();
        }
    }
// ...existing code...
```

이렇게 하면 텍스트 박스에서 엔터를 쳤을 때 버튼을 클릭한 것과 동일하게 동작합니다. `e.SuppressKeyPress = true;`는 엔터 입력 시 발생하는 시스템 경고음("띵" 소리)을 막아주는 역할을 합니다.



# > 대화를 계속 하다보면 대화내용이 스크롤 생기면서 잘릴 텐데... 대화후 rich 박스의 스크롤을 맨 아래로 내리는 기능을 추가하려면 어떻게하니?

fp024: 근데 VSCode C# Dev Kit에서 프로젝트 만들면  cs 소스파일을 UTF-8 BOM으로 생성해내니?

VS Code: C# Dev Kit에서 새 프로젝트를 만들 때 생성되는 .cs 파일의 기본 인코딩은 Visual Studio Code의 **files.encoding** 설정에 따라 결정됩니다.  
이 설정이 "utf8bom"으로 되어 있으면 UTF-8 BOM으로 파일이 생성됩니다.  
기본값은 "utf8"이므로 BOM 없이 생성됩니다.

1. **files.encoding** 설정을 확인하거나 변경하세요.
2. "utf8bom"으로 설정하면 새로 생성되는 파일이 UTF-8 BOM으로 저장됩니다.

# > 지금 리치박스가 disable이여서 내가 맘데로 스크롤을 조정할 수는 없나보다?

네, 맞습니다. `richTextBox1.Enabled = false;`로 설정되어 있으면 사용자가 마우스나 키보드로 스크롤을 조작할 수 없습니다.

하지만 **코드로 스크롤을 내리는 기능(`ScrollToCaret`)은 `Enabled = false` 상태에서도 정상적으로 동작**해야 합니다.

만약 사용자가 직접 스크롤을 움직여서 지난 대화를 보고 싶다면, `Enabled = false` 대신 **`ReadOnly = true`** 속성을 사용하는 것이 좋습니다.

`ReadOnly = true`로 설정하면:
1.  사용자가 내용을 수정할 수는 없지만,
2.  **스크롤을 자유롭게 움직일 수 있고**,
3.  텍스트를 드래그해서 복사할 수도 있습니다.

생성자에서 설정을 변경해 보세요.

```csharp
// ...existing code...
    public Form1()
    {
        InitializeComponent();
        // richTextBox1.Enabled = false; // 기존 코드 주석 처리
        richTextBox1.ReadOnly = true;    // 읽기 전용으로 설정 (스크롤 가능)
        richTextBox1.BackColor = SystemColors.Window; // 배경색을 흰색으로 유지 (선택 사항)

        button1.Click += Button1_Click;
// ...existing code...
```

이렇게 하면 사용자가 지난 대화를 스크롤해서 볼 수 있게 됩니다.







## 정오표

* ...





## 사용 아이콘

💡⬜✅✔✨👍😅