namespace ChatBot;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new System.Drawing.Point(2, 1);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(795, 642);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(2, 649);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(692, 29);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(695, 649);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(101, 28);
        button1.TabIndex = 2;
        button1.Text = "전송";
        button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 679);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(richTextBox1);
        Text = "ChatBot";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;

    #endregion
}
