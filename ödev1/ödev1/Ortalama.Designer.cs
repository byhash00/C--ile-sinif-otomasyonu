namespace ödev1
{
    partial class Ortalama
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            comboBoxOgr = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(303, 346);
            button1.Name = "button1";
            button1.Size = new Size(155, 50);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 198);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 1;
            label1.Text = "Harmonik Ortalama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 198);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 2;
            label2.Text = "Geometrik Ortalama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 198);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 3;
            label3.Text = "Aritmetik Ortalama";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(144, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(323, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(504, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 67);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "DERS SEÇİNİZ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BİLİŞİM GÜVENLİĞİ VE HUKUKU", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ 2", "YABANCI DİL 2", "TÜRK DiLİ 2", "İNTERNET PROGRAMCILIĞI", "GÖRSEL PROGRAMLAMA 1", "STAJ 1", "PROJELENDİRME VE UYGULAMA" });
            comboBox1.Location = new Point(271, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxOgr
            // 
            comboBoxOgr.FormattingEnabled = true;
            comboBoxOgr.Location = new Point(271, 112);
            comboBoxOgr.Name = "comboBoxOgr";
            comboBoxOgr.Size = new Size(272, 28);
            comboBoxOgr.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 115);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 10;
            label5.Text = "ÖĞRENCİ SEÇİNİZ";
            // 
            // Ortalama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxOgr);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Ortalama";
            Text = "Ortalama";
            Load += Ortalama_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button2;
        private ComboBox comboBoxOgr;
        private Label label5;
    }
}