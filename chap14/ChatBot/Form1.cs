using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChatBot;

public partial class Form1 : Form
{
    private static readonly HttpClient _client = new();

    public Form1()
    {
        InitializeComponent();
        richTextBox1.ReadOnly = true;

        button1.Click += Button1_Click;
        // 텍스트 박스에서 키 입력 이벤트 연결
        textBox1.KeyDown += TextBox1_KeyDown;
    }

    private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
    {
        // Enter 키가 눌렸고, 텍스트가 비어있지 않다면 전송
        if (e.KeyCode != Keys.Enter || string.IsNullOrWhiteSpace(textBox1.Text))
        {
            return;
        }

        // 띵 소리 방지 (선택 사항)
        e.SuppressKeyPress = true;
        // 전송 버튼 클릭 효과
        button1.PerformClick();
    }

    // 인공지능 메시지를 나타내는 클래스
    private sealed class Message(string role, string text)
    {
        [JsonPropertyName("role")]
        public string Role { get; set; } = role;
        [JsonPropertyName("parts")]
        public Part[] Parts { get; set; } = [new() { Text = text }];
    }

    private sealed class Part
    {
        [JsonPropertyName("text")]
        public required string Text { get; set; }
    }

    // 메시지를 저장하는 리스트
    private readonly List<Message> _messages = [];

    private async void Button1_Click(object? sender, EventArgs e)
    {
        try
        {
            // 사용자 메시지를 읽고
            // UI를 사용하지 못하게 막습니다.
            var userMessage = textBox1.Text.Trim();
            richTextBox1.AppendText($"[user] {userMessage}\n");
            textBox1.Text = "통신 중....";
            textBox1.Enabled = false;
            button1.Enabled = false;

            // 통신합니다.
            var assistantResponse = await GetAiResponseAsync(userMessage);
            richTextBox1.AppendText($"[assistant] {assistantResponse}\n");

            // 💡 스크롤을 맨 아래로 이동
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            // 통신 완료 후 데이터를 출력하고
            // UI를 사용 가능한 상태로 되돌립니다.
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Enabled = true;
        }
        catch (Exception exception)
        {
            MessageBox.Show($"오류 발생: {exception.Message}");
        }
    }

    private async Task<string> GetAiResponseAsync(string userMessage)
    {
        // 메시지를 추가합니다.
        _messages.Add(new Message("user", userMessage));

        // API 키를 환경 변수에서 가져옵니다.
        var apiKey = Environment.GetEnvironmentVariable("GOOGLE_API_KEY");
        if (string.IsNullOrEmpty(apiKey))
        {
            throw new InvalidOperationException("GOOGLE_API_KEY 환경 변수가 설정되지 않았습니다.");
        }

        // Gemini API 요청 본문 구성
        var requestBody = new
        {
            // 💡 최근 대화 10개만 전송
            contents = _messages.TakeLast(10).ToList()
        };

        // HTTP 요청합니다.
        var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={apiKey}";

        var response = await _client.PostAsync(
            url,
            new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json"));

        response.EnsureSuccessStatusCode();

        // HTTP 응답을 받고 content를 추출 합니다.
        var responseBody = await response.Content.ReadAsStringAsync();
        using var document = JsonDocument.Parse(responseBody);

        // Gemini 응답 구조: candidates[0].content.parts[0].text
        var assistantMessage = document.RootElement
            .GetProperty("candidates")[0]
            .GetProperty("content")
            .GetProperty("parts")[0]
            .GetProperty("text")
            .GetString()!;

        _messages.Add(new Message("model", assistantMessage));
        return assistantMessage.Trim();
    }
}
