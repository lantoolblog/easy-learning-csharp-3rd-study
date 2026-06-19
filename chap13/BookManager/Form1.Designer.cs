namespace BookManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            도서관리ToolStripMenuItem = new ToolStripMenuItem();
            사용자관리ToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 도서관리ToolStripMenuItem, 사용자관리ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1025, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem1";
            도서관리ToolStripMenuItem.Size = new Size(86, 25);
            도서관리ToolStripMenuItem.Text = "도서관리";
            도서관리ToolStripMenuItem.Click += ToolStripMenuItem1_Click;
            // 
            // 사용자관리ToolStripMenuItem
            // 
            사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem2";
            사용자관리ToolStripMenuItem.Size = new Size(108, 25);
            사용자관리ToolStripMenuItem.Text = "사용자 관리";
            사용자관리ToolStripMenuItem.Click += ToolStripMenuItem2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "도서관 현황";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(180, 135);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(180, 102);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 68);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 36);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 135);
            label4.Name = "label4";
            label4.Size = new Size(160, 21);
            label4.TabIndex = 3;
            label4.Text = "연체 중인 도서의 수:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 102);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 2;
            label3.Text = "대출 중인 도서의 수:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 68);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "사용자 수:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "전체 도서 수:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(512, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 174);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "대여 / 반납";
            // 
            // button2
            // 
            button2.Location = new Point(379, 87);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 7;
            button2.Text = "반납";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(379, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 6;
            button1.Text = "대여";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 29);
            textBox1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 119);
            label11.Name = "label11";
            label11.Size = new Size(79, 21);
            label11.TabIndex = 2;
            label11.Text = "사용자 ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 84);
            label10.Name = "label10";
            label10.Size = new Size(80, 21);
            label10.TabIndex = 1;
            label10.Text = "도서 이름";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 46);
            label9.Name = "label9";
            label9.Size = new Size(40, 21);
            label9.TabIndex = 0;
            label9.Text = "isbn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(26, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(973, 257);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "도서 현황";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(961, 226);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(26, 507);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(973, 251);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "사용자 현황";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(964, 220);
            dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 779);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "도서관 관리";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 도서관리ToolStripMenuItem;
        private ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
    }
}
