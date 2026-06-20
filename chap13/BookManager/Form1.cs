using BookManager.Model;
using BookManager.Service;

namespace BookManager;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Text = "도서관 관리";

        // 데이터 변경 이벤트 구독
        DataManager.DataChanged += (sender, e) => UpdateStatusLabels();

        // 라벨 설정
        UpdateStatusLabels();

        // 데이터 그리드 설정
        dataGridView1.DataSource = DataManager.Books;
        dataGridView1.ReadOnly = true;
        dataGridView1.MultiSelect = false;

        dataGridView2.DataSource = DataManager.Users;
        dataGridView2.ReadOnly = true;
        dataGridView2.MultiSelect = false;

        dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
        dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;

        // 버튼 이벤트 설정
        button1.Click += Button1_Click;
        button2.Click += Button2_Click;
    }

    private void UpdateStatusLabels()
    {
        label5.Text = DataManager.Books.Count.ToString();
        label6.Text = DataManager.Users.Count.ToString();
        label7.Text = DataManager.Books.Count(x => x.IsBorrowed).ToString();
        label8.Text = DataManager.Books.Count(x =>
            x.IsBorrowed && x.BorrowedAt?.AddDays(7) < DateTime.Now
        ).ToString();
    }

    // 도서 현황 그리드 뷰
    private void DataGridView1_CurrentCellChanged(object? sender, EventArgs e)
    {
        // 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
        var book = dataGridView1.CurrentRow?.DataBoundItem as Book;
        textBox1.Text = book?.Isbn ?? string.Empty;
        textBox2.Text = book?.Name ?? string.Empty;
        textBox3.Text = book?.UserId == 0 ? string.Empty : book?.UserId.ToString();
    }

    // 사용자 현황 그리드 뷰
    private void DataGridView2_CurrentCellChanged(object? sender, EventArgs e)
    {
        // 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
        var user = dataGridView2.CurrentRow?.DataBoundItem as User;
        textBox3.Text = user?.Id.ToString() ?? string.Empty;
    }

    // 대여 버튼
    private void Button1_Click(object? sender, EventArgs e)
    {
        if (textBox1.Text.Trim() == "")
        {
            MessageBox.Show("Isbn을 입력해주세요");
        }
        else if (textBox3.Text.Trim() == "")
        {
            MessageBox.Show("사용자 ID를 입력해주세요");
        }
        else
        {
            try
            {
                var book = DataManager.Books.Single(x => x.Isbn == textBox1.Text);
                if (book.IsBorrowed)
                {
                    MessageBox.Show("이미 대여 중인 도서입니다.");
                }
                else
                {
                    // Single 메서드는 조건에 맞는 대상 객체 하나를 추출하는 메서드
                    var user = DataManager.Users.Single(x => x.Id.ToString() == textBox3.Text);
                    book.UserId = user.Id;
                    book.UserName = user.Name;
                    book.IsBorrowed = true;
                    book.BorrowedAt = DateTime.Now;

                    // 그리드를 새로고침하고 XML로 저장하는 코드
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
            }
        }
    }

    // 반납 버튼
    private void Button2_Click(object? sender, EventArgs e)
    {
        if (textBox1.Text.Trim() == "")
        {
            MessageBox.Show("Isbn을 입력해주세요");
        }
        else
        {
            try
            {
                var book = DataManager.Books.Single(x => x.Isbn == textBox1.Text);
                if (book.IsBorrowed)
                {
                    // 💡불필요한 코드 같다.
                    // var user = DataManager.Users.Single((x) => x.Id == book.UserId);
                    book.UserId = 0;
                    book.UserName = "";
                    book.IsBorrowed = false;
                    book.BorrowedAt = new DateTime();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();

                    MessageBox.Show(book.BorrowedAt?.AddDays(7) > DateTime.Now
                        ? $@"{book.Name}이/가 연체 상태로 반납되었습니다."
                        : $@"{book.Name}이/가 반납되었습니다.");
                }
                else
                {
                    MessageBox.Show("대여 상태가 아닙니다.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
            }
        }
    }

    private void ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        // 메뉴를 누르면 새로운 윈도 폼을 출력하고,
        // 돌아오면 데이터 그리드 뷰를 새로 고침한다.
        new Form2().ShowDialog();
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = DataManager.Books;
    }

    private void ToolStripMenuItem2_Click(object sender, EventArgs e)
    {
        new Form3().ShowDialog();
        dataGridView2.DataSource = null;
        dataGridView2.DataSource = DataManager.Users;
    }
}
