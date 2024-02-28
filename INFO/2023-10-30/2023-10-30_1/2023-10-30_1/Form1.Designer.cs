namespace _2023_10_30_1 {
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            n_tracce = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            inserisci = new Button();
            Rimuovi = new Button();
            modifica = new Button();
            copia = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titolo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 66);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Artista:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 90);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Durata (s):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 119);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome Album:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 138);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "N° Tracce:";
            // 
            // n_tracce
            // 
            n_tracce.AutoSize = true;
            n_tracce.Location = new Point(188, 141);
            n_tracce.Name = "n_tracce";
            n_tracce.Size = new Size(0, 15);
            n_tracce.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 163);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Ghost-track:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sì", "No" });
            comboBox1.Location = new Point(188, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(188, 88);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(411, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(391, 439);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // inserisci
            // 
            inserisci.Location = new Point(41, 213);
            inserisci.Name = "inserisci";
            inserisci.Size = new Size(188, 52);
            inserisci.TabIndex = 13;
            inserisci.Text = "Inserisci";
            inserisci.UseVisualStyleBackColor = true;
            inserisci.Click += inserisci_Click;
            // 
            // Rimuovi
            // 
            Rimuovi.Location = new Point(42, 271);
            Rimuovi.Name = "Rimuovi";
            Rimuovi.Size = new Size(187, 54);
            Rimuovi.TabIndex = 14;
            Rimuovi.Text = "Rimuovi";
            Rimuovi.UseVisualStyleBackColor = true;
            Rimuovi.Click += Rimuovi_Click;
            // 
            // modifica
            // 
            modifica.Location = new Point(42, 331);
            modifica.Name = "modifica";
            modifica.Size = new Size(187, 54);
            modifica.TabIndex = 15;
            modifica.Text = "Modifica";
            modifica.UseVisualStyleBackColor = true;
            modifica.Click += modifica_Click;
            // 
            // copia
            // 
            copia.Location = new Point(42, 391);
            copia.Name = "copia";
            copia.Size = new Size(187, 54);
            copia.TabIndex = 16;
            copia.Text = "Copia";
            copia.UseVisualStyleBackColor = true;
            copia.Click += copia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(copia);
            Controls.Add(modifica);
            Controls.Add(Rimuovi);
            Controls.Add(inserisci);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(n_tracce);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label n_tracce;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button inserisci;
        private Button Rimuovi;
        private Button modifica;
        private Button copia;
    }
}