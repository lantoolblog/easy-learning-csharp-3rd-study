namespace BookManager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "도서 추가/수정/삭제";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 0;
            label1.Text = "isbn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "도서 이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 1;
            label3.Text = "출판사";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 2;
            label4.Text = "페이지";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 29);
            textBox4.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(6, 189);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 7;
            button1.Text = "추가";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(113, 189);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 8;
            button2.Text = "수정";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(201, 189);
            button3.Name = "button3";
            button3.Size = new Size(92, 30);
            button3.TabIndex = 9;
            button3.Text = "삭제";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(20, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 314);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "도서 현황";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(570, 280);
            dataGridView1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 597);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "도서 관리";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}