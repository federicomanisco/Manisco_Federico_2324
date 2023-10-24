namespace _2023_10_25_1___FootballManager {
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
            listBox1 = new ListBox();
            label1 = new Label();
            allena = new Button();
            numericUpDown1 = new NumericUpDown();
            inserisci = new Button();
            cancella = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(462, 409);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 426);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // allena
            // 
            allena.Location = new Point(536, 371);
            allena.Name = "allena";
            allena.Size = new Size(252, 50);
            allena.TabIndex = 2;
            allena.Text = "Allena";
            allena.UseVisualStyleBackColor = true;
            allena.Click += allena_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(628, 342);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(160, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // inserisci
            // 
            inserisci.Location = new Point(536, 12);
            inserisci.Name = "inserisci";
            inserisci.Size = new Size(252, 50);
            inserisci.TabIndex = 4;
            inserisci.Text = "Inserisci";
            inserisci.UseVisualStyleBackColor = true;
            inserisci.Click += inserisci_Click;
            // 
            // cancella
            // 
            cancella.Location = new Point(536, 282);
            cancella.Name = "cancella";
            cancella.Size = new Size(252, 54);
            cancella.TabIndex = 5;
            cancella.Text = "Cancella";
            cancella.UseVisualStyleBackColor = true;
            cancella.Click += cancella_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(588, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(654, 68);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Cognome:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(723, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 23);
            textBox2.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(588, 94);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(60, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 96);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "Maglia:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(545, 120);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(654, 96);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 13;
            label5.Text = "Data di nascita:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(cancella);
            Controls.Add(inserisci);
            Controls.Add(numericUpDown1);
            Controls.Add(allena);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button allena;
        private NumericUpDown numericUpDown1;
        private Button inserisci;
        private Button cancella;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Label label5;
    }
}