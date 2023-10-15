namespace _2023_10_16_3 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            textBox1 = new TextBox();
            Aggiungi = new Button();
            label2 = new Label();
            label3 = new Label();
            Minimo = new Label();
            Massimo = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            Occorrenze = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            Somma = new Label();
            listBox1 = new ListBox();
            Esegui = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // Aggiungi
            // 
            Aggiungi.Location = new Point(201, 54);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(75, 23);
            Aggiungi.TabIndex = 2;
            Aggiungi.Text = "Aggiungi";
            Aggiungi.UseVisualStyleBackColor = true;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 137);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Minimo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 181);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Massimo:";
            // 
            // Minimo
            // 
            Minimo.AutoSize = true;
            Minimo.Location = new Point(139, 137);
            Minimo.Name = "Minimo";
            Minimo.Size = new Size(16, 15);
            Minimo.TabIndex = 5;
            Minimo.Text = "...";
            // 
            // Massimo
            // 
            Massimo.AutoSize = true;
            Massimo.Location = new Point(139, 181);
            Massimo.Name = "Massimo";
            Massimo.Size = new Size(16, 15);
            Massimo.TabIndex = 6;
            Massimo.Text = "...";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 230);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 8;
            label4.Text = "Occorrenze di:";
            // 
            // Occorrenze
            // 
            Occorrenze.AutoSize = true;
            Occorrenze.Location = new Point(212, 233);
            Occorrenze.Name = "Occorrenze";
            Occorrenze.Size = new Size(16, 15);
            Occorrenze.TabIndex = 9;
            Occorrenze.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 279);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "Somma a tutti:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 23);
            textBox3.TabIndex = 11;
            // 
            // Somma
            // 
            Somma.AutoSize = true;
            Somma.Location = new Point(212, 279);
            Somma.Name = "Somma";
            Somma.Size = new Size(16, 15);
            Somma.TabIndex = 12;
            Somma.Text = "...";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(376, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(399, 364);
            listBox1.TabIndex = 13;
            // 
            // Esegui
            // 
            Esegui.Location = new Point(234, 276);
            Esegui.Name = "Esegui";
            Esegui.Size = new Size(75, 23);
            Esegui.TabIndex = 14;
            Esegui.Text = "Esegui";
            Esegui.UseVisualStyleBackColor = true;
            Esegui.Click += Esegui_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Esegui);
            Controls.Add(listBox1);
            Controls.Add(Somma);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(Occorrenze);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(Massimo);
            Controls.Add(Minimo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Aggiungi);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button Aggiungi;
        private Label label2;
        private Label label3;
        private Label Minimo;
        private Label Massimo;
        private TextBox textBox2;
        private Label label4;
        private Label Occorrenze;
        private Label label5;
        private TextBox textBox3;
        private Label Somma;
        private ListBox listBox1;
        private Button Esegui;
    }
}