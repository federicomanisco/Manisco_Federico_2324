namespace _2023_10_27 {
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
            inserisci = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            raccoltaFlag = new ComboBox();
            listBox1 = new ListBox();
            modifica = new Button();
            cancella = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titolo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Autore:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 98);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero Pagine:";
            // 
            // inserisci
            // 
            inserisci.Location = new Point(42, 196);
            inserisci.Name = "inserisci";
            inserisci.Size = new Size(233, 40);
            inserisci.TabIndex = 3;
            inserisci.Text = "Inserisci";
            inserisci.UseVisualStyleBackColor = true;
            inserisci.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 125);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Genere:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 151);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Raccolta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(175, 93);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // raccoltaFlag
            // 
            raccoltaFlag.FormattingEnabled = true;
            raccoltaFlag.Items.AddRange(new object[] { "Sì", "No" });
            raccoltaFlag.Location = new Point(175, 148);
            raccoltaFlag.Name = "raccoltaFlag";
            raccoltaFlag.Size = new Size(100, 23);
            raccoltaFlag.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(281, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(519, 409);
            listBox1.TabIndex = 11;
            // 
            // modifica
            // 
            modifica.Location = new Point(42, 257);
            modifica.Name = "modifica";
            modifica.Size = new Size(233, 40);
            modifica.TabIndex = 12;
            modifica.Text = "Modifica";
            modifica.UseVisualStyleBackColor = true;
            modifica.Click += modifica_Click;
            // 
            // cancella
            // 
            cancella.Location = new Point(42, 320);
            cancella.Name = "cancella";
            cancella.Size = new Size(233, 40);
            cancella.TabIndex = 13;
            cancella.Text = "Cancella";
            cancella.UseVisualStyleBackColor = true;
            cancella.Click += cancella_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancella);
            Controls.Add(modifica);
            Controls.Add(listBox1);
            Controls.Add(raccoltaFlag);
            Controls.Add(textBox3);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inserisci);
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
        private Button inserisci;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private ComboBox raccoltaFlag;
        private ListBox listBox1;
        private Button modifica;
        private Button cancella;
    }
}