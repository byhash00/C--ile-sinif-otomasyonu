namespace ödev1
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            sınıfMevcuduTextBox = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BİLİŞİM GÜVENLİĞİ VE HUKUKU", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ 2", "YABANCI DİL 2", "TÜRK DiLİ 2", "İNTERNET PROGRAMCILIĞI", "GÖRSEL PROGRAMLAMA 1", "STAJ 1", "PROJELENDİRME VE UYGULAMA" });
            comboBox1.Location = new Point(292, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 28);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(635, 409);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 1;
            button1.Text = "Öğrenci Listesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(93, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Sınıf Mevcudu";
            // 
            // sınıfMevcuduTextBox
            // 
            sınıfMevcuduTextBox.Location = new Point(93, 70);
            sınıfMevcuduTextBox.Name = "sınıfMevcuduTextBox";
            sınıfMevcuduTextBox.Size = new Size(125, 27);
            sınıfMevcuduTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Dersler";
            // 
            // button2
            // 
            button2.Location = new Point(635, 374);
            button2.Name = "button2";
            button2.Size = new Size(153, 29);
            button2.TabIndex = 6;
            button2.Text = "Öğrenci Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(635, 339);
            button4.Name = "button4";
            button4.Size = new Size(153, 29);
            button4.TabIndex = 8;
            button4.Text = "Ortalama Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(sınıfMevcuduTextBox);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private TextBox sınıfMevcuduTextBox;
        private Label label2;
        private Button button2;
        private Button button4;
    }
}
